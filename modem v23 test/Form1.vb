Imports System.IO
Imports System.Media


Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Data(32768) As Byte
        For i As Integer = 0 To repeat_times_user.Value
            If random_data_switch_user.Checked Then
                Data(i) = CInt(Int((255 * Rnd()) + 1))
            End If
        Next
        SendByte(Data, speed_user.Value, repeat_times_user.Value)
        Return
    End Sub

    Public Shared Sub SendByte(ByRef Data() As Byte, ByVal Speed As Integer, ByVal Len As Integer)
        ' Now keeps track of phase to get better transitions between frequency changes (and presumably better snr)
        Dim Symbols As Array = New Integer() {1700, 1300, 2100} ' index 0 for idle freq
        Dim Frequency As Integer = Symbols(0)
        Dim Symbol_total = 8 * Len
        Dim Symbol_duration As Single = 100 / Speed ' (1 / Speed) * 100
        Dim Duration As Single = Symbol_duration * Symbol_total
        Dim A As Double = ((System.Math.Pow(2, 15))) - 1    ' because 16 bits signed samples : -32768~32767. 2^15 = 32768. -1 for 32767 in positive halfcycle
        Dim Samples_per_symbol As Integer = 441 * Symbol_duration / 10
        'Dim Samples As Integer = 441 * Duration / 10
        Dim Samples As Integer = Samples_per_symbol * Symbol_total
        Dim Bytes As Integer = Samples * 4
        Dim PhaseInt As Double = 0

        Dim Header As Integer() = {1179011410, 36 + Bytes, 1163280727, 544501094, 16, 131073, 44100, 176400, 1048580, 1635017060, Bytes}

        Using MS As MemoryStream = New MemoryStream(44 + Bytes)

            Using BW As BinaryWriter = New BinaryWriter(MS)

                For I As Integer = 0 To Header.Length - 1
                    BW.Write(Header(I))
                Next

                Dim bitcounter As Integer = 0
                For T As Integer = 0 To Samples - 1
                    'For Ts As Integer = 0 To Samples_per_symbol * 1
                    If (T Mod Samples_per_symbol) = 0 Then  ' if it's time to change symbol (? i think)
                        'MessageBox.Show(T)
                        Dim bit = (Data(Math.Floor(bitcounter / 8)) >> bitcounter) And 1
                        Frequency = Symbols(bit + 1)
                        bitcounter += 1
                    End If
                    PhaseInt += (2 * Math.PI * Frequency / 44100.0)  ' integrate samples to get phase
                    If PhaseInt >= 2 * Math.PI Then  ' keep phase between 0 and 2pi
                        PhaseInt -= 2 * Math.PI
                    End If
                    Dim Sample As Short = System.Convert.ToInt16(A * Math.Sin(PhaseInt))
                    BW.Write(Sample)
                    BW.Write(Sample)
                    'Next
                Next

                BW.Flush()
                MS.Seek(0, SeekOrigin.Begin)

                Using SP As SoundPlayer = New SoundPlayer(MS)
                    SP.Play()
                End Using
            End Using
        End Using
    End Sub

    Public Shared Sub SendByte_old(ByRef Data() As Byte, ByVal Speed As Integer, ByVal Len As Integer)
        Dim Symbols As Array = New Integer() {1300, 2100}
        Dim Frequency As Integer = Symbols(1)
        Dim Symbol_total = 8 * Len
        Dim Symbol_duration As Single = (1 / Speed) * 100
        Dim Duration As Single = Symbol_duration * Symbol_total
        Dim A As Double = ((System.Math.Pow(2, 15))) - 1
        Dim Samples_per_symbol As Integer = 441 * Symbol_duration / 10
        'Dim Samples As Integer = 441 * Duration / 10
        Dim Samples As Integer = Samples_per_symbol * Symbol_total
        Dim Bytes As Integer = Samples * 4
        Dim DeltaFT As Double = 2 * Math.PI * 1700 / 44100.0

        Dim Header As Integer() = {1179011410, 36 + Bytes, 1163280727, 544501094, 16, 131073, 44100, 176400, 1048580, 1635017060, Bytes}

        Using MS As MemoryStream = New MemoryStream(44 + Bytes)

            Using BW As BinaryWriter = New BinaryWriter(MS)

                For I As Integer = 0 To Header.Length - 1
                    BW.Write(Header(I))
                Next

                Dim bitcounter As Integer = 0
                For T As Integer = 0 To Samples - 1
                    'For Ts As Integer = 0 To Samples_per_symbol * 1
                    If (T Mod Samples_per_symbol) = 0 Then
                        'MessageBox.Show(T)
                        Dim bit = (Data(Math.Floor(bitcounter / 8)) >> bitcounter) And 1
                        Frequency = Symbols(bit)
                        DeltaFT = 2 * Math.PI * Frequency / 44100.0
                        bitcounter += 1
                    End If
                    Dim Sample As Short = System.Convert.ToInt16(A * Math.Sin(DeltaFT * T))
                    BW.Write(Sample)
                    BW.Write(Sample)
                    'Next
                Next

                BW.Flush()
                MS.Seek(0, SeekOrigin.Begin)

                Using SP As SoundPlayer = New SoundPlayer(MS)
                    SP.PlaySync()
                End Using
            End Using
        End Using
    End Sub

    Public Shared Sub FrequencyBeep(ByVal Amplitude As Integer, ByVal Frequency As Integer, ByVal Duration As Integer)
        Dim A As Double = ((Amplitude * (System.Math.Pow(2, 15))) / 1000) - 1
        Dim DeltaFT As Double = 2 * Math.PI * Frequency / 44100.0
        Dim Samples As Integer = 441 * Duration / 10
        Dim Bytes As Integer = Samples * 4

        Dim Header As Integer() = {1179011410, 36 + Bytes, 1163280727, 544501094, 16, 131073, 44100, 176400, 1048580, 1635017060, Bytes}

        Using MS As MemoryStream = New MemoryStream(44 + Bytes)

            Using BW As BinaryWriter = New BinaryWriter(MS)

                For I As Integer = 0 To Header.Length - 1
                    BW.Write(Header(I))
                Next

                For T As Integer = 0 To Samples - 1
                    Dim Sample As Short = System.Convert.ToInt16(A * Math.Sin(DeltaFT * T))
                    BW.Write(Sample)
                    BW.Write(Sample)
                Next

                BW.Flush()
                MS.Seek(0, SeekOrigin.Begin)

                Using SP As SoundPlayer = New SoundPlayer(MS)
                    SP.PlaySync()
                End Using
            End Using
        End Using
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        VBMath.Randomize()
    End Sub
End Class

