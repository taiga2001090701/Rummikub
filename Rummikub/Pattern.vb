Imports System.Collections
Imports System.Drawing

Public Class Pattern
    Public el As ArrayList
    Dim elt As String

    Private Sub Pattern_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With RT
            For i = 0 To el.Count - 1
                If Not el(i).ToString = "0" Then
                    If i > 0 Then
                        .AppendText(vbCrLf)
                    End If
                    elt = el(i).ToString
                    For ii = 0 To elt.Length / 3 - 1
                        .SelectionStart = .Text.Length
                        Select Case elt.Substring(ii * 3, 1)
                            Case "A"
                                .SelectionColor = Color.Black
                                .AppendText(CInt(elt.Substring(ii * 3 + 1, 2)) & " ")
                            Case "B"
                                .SelectionColor = Color.Red
                                .AppendText(CInt(elt.Substring(ii * 3 + 1, 2)) & " ")
                            Case "C"
                                .SelectionColor = Color.Orange
                                .AppendText(CInt(elt.Substring(ii * 3 + 1, 2)) & " ")
                            Case "D"
                                .SelectionColor = Color.Blue
                                .AppendText(CInt(elt.Substring(ii * 3 + 1, 2)) & " ")
                            Case "J"
                                .SelectionColor = Color.Black
                                .AppendText("J ")
                        End Select
                    Next
                End If
            Next
            If .Text = "" Then
                .Text = "パターンが見つかりませんでした。"
            End If
        End With
    End Sub
End Class