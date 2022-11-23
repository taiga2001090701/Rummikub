Imports System.Collections
Imports System.Drawing
Imports System.Windows.Forms

Public Class Main
    Dim bsn, bc As Long
    Dim ea, eb, er As New ArrayList
    Dim ms, mst As Long

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bsn = 0
        Button0.BackColor = Color.Lime
        G1.Enabled = True
        G2.Enabled = False
    End Sub

    Private Sub BC_Click(sender As Object, e As EventArgs) Handles BC1.Click, BC2.Click, BC3.Click, BC4.Click
        bc = sender.Name.ToString.Substring(2)
        G1.Enabled = False
        G2.Enabled = True
    End Sub

    Private Sub BJ_Click(sender As Object, e As EventArgs) Handles BJ.Click
        CType(Controls.Find("Button" & bsn, False)(0), Button).ForeColor = CfN(1)
        CType(Controls.Find("Button" & bsn, False)(0), Button).Text = "J"
    End Sub

    Private Sub BE_Click(sender As Object, e As EventArgs) Handles BE.Click
        CType(Controls.Find("Button" & bsn, False)(0), Button).ForeColor = CfN(1)
        CType(Controls.Find("Button" & bsn, False)(0), Button).Text = ""
    End Sub

    Private Sub BN_Click(sender As Object, e As EventArgs) Handles BN9.Click, BN8.Click, BN7.Click, BN6.Click, BN5.Click, BN4.Click, BN3.Click, BN2.Click, BN13.Click, BN12.Click, BN11.Click, BN10.Click, BN1.Click
        CType(Controls.Find("Button" & bsn, False)(0), Button).ForeColor = CfN(bc)
        CType(Controls.Find("Button" & bsn, False)(0), Button).Text = sender.Name.ToString.Substring(2)
        G1.Enabled = True
        G2.Enabled = False
    End Sub

    Private Function CfN(c As Long) As Color
        Select Case c
            Case 1
                Return Color.Black
            Case 2
                Return Color.Red
            Case 3
                Return Color.Orange
            Case 4
                Return Color.Blue
        End Select
    End Function

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button99.Click, Button98.Click, Button97.Click, Button96.Click, Button95.Click, Button94.Click, Button93.Click, Button92.Click, Button91.Click, Button90.Click, Button9.Click, Button89.Click, Button88.Click, Button87.Click, Button86.Click, Button85.Click, Button84.Click, Button83.Click, Button82.Click, Button81.Click, Button80.Click, Button8.Click, Button79.Click, Button78.Click, Button77.Click, Button76.Click, Button75.Click, Button74.Click, Button73.Click, Button72.Click, Button71.Click, Button70.Click, Button7.Click, Button69.Click, Button68.Click, Button67.Click, Button66.Click, Button65.Click, Button64.Click, Button63.Click, Button62.Click, Button61.Click, Button60.Click, Button6.Click, Button59.Click, Button58.Click, Button57.Click, Button56.Click, Button55.Click, Button54.Click, Button53.Click, Button52.Click, Button51.Click, Button50.Click, Button5.Click, Button49.Click, Button48.Click, Button47.Click, Button46.Click, Button45.Click, Button44.Click, Button43.Click, Button42.Click, Button41.Click, Button40.Click, Button4.Click, Button39.Click, Button38.Click, Button37.Click, Button36.Click, Button35.Click, Button34.Click, Button33.Click, Button32.Click, Button31.Click, Button30.Click, Button3.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click, Button0.Click, Button139.Click, Button138.Click, Button137.Click, Button136.Click, Button135.Click, Button134.Click, Button133.Click, Button132.Click, Button131.Click, Button130.Click, Button129.Click, Button128.Click, Button127.Click, Button126.Click, Button125.Click, Button124.Click, Button123.Click, Button122.Click, Button121.Click, Button120.Click, Button119.Click, Button118.Click, Button117.Click, Button116.Click, Button115.Click, Button114.Click, Button113.Click, Button112.Click, Button111.Click, Button110.Click, Button109.Click, Button108.Click, Button107.Click, Button106.Click, Button105.Click, Button104.Click, Button103.Click, Button102.Click, Button101.Click, Button100.Click
        G1.Enabled = True
        G2.Enabled = False
        For i = 0 To 139
            CType(Controls.Find("Button" & i, False)(0), Button).BackColor = Color.PapayaWhip
        Next
        CType(Controls.Find(sender.Name.ToString, False)(0), Button).BackColor = Color.Lime
        bsn = sender.Name.ToString.Substring(6)
    End Sub

    Private Sub BS_Click(sender As Object, e As EventArgs) Handles BS.Click
        Enabled = False
        ea.Clear()
        eb.Clear()
        For i As Long = 0 To 99
            With CType(Controls.Find("Button" & i, False)(0), Button)
                If Not .Text = "" Then
                    If .Text = "J" Then
                        ea.Add("JJJ")
                    ElseIf .ForeColor = Color.Black Then
                        If .Text.Length < 2 Then
                            ea.Add("A" & "0" & .Text)
                        Else
                            ea.Add("A" & .Text)
                        End If
                    ElseIf .ForeColor = Color.Red Then
                        If .Text.Length < 2 Then
                            ea.Add("B" & "0" & .Text)
                        Else
                            ea.Add("B" & .Text)
                        End If
                    ElseIf .ForeColor = Color.Orange Then
                        If .Text.Length < 2 Then
                            ea.Add("C" & "0" & .Text)
                        Else
                            ea.Add("C" & .Text)
                        End If
                    ElseIf .ForeColor = Color.Blue Then
                        If .Text.Length < 2 Then
                            ea.Add("D" & "0" & .Text)
                        Else
                            ea.Add("D" & .Text)
                        End If
                    End If
                End If
            End With
        Next
        For i As Long = 100 To 139
            With CType(Controls.Find("Button" & i, False)(0), Button)
                If Not .Text = "" Then
                    If .Text = "J" Then
                        eb.Add("JJJ")
                    ElseIf .ForeColor = Color.Black Then
                        If .Text.Length < 2 Then
                            eb.Add("A" & "0" & .Text)
                        Else
                            eb.Add("A" & .Text)
                        End If
                    ElseIf .ForeColor = Color.Red Then
                        If .Text.Length < 2 Then
                            eb.Add("B" & "0" & .Text)
                        Else
                            eb.Add("B" & .Text)
                        End If
                    ElseIf .ForeColor = Color.Orange Then
                        If .Text.Length < 2 Then
                            eb.Add("C" & "0" & .Text)
                        Else
                            eb.Add("C" & .Text)
                        End If
                    ElseIf .ForeColor = Color.Blue Then
                        If .Text.Length < 2 Then
                            eb.Add("D" & "0" & .Text)
                        Else
                            eb.Add("D" & .Text)
                        End If
                    End If
                End If
            End With
        Next
        ms = 0
        P1.Maximum = eb.Count
        P1.Value = 0
        For i As Long = 0 To eb.Count - 1
            LB("", eb, i, True)
            P1.Value = i + 1
        Next
        Dim fp As New Pattern
        fp.el = CType(er.Clone, ArrayList)
        fp.ShowDialog(Me)
        fp.Dispose()
        P1.Value = 0
        P2.Value = 0
        P3.Value = 0
        Enabled = True
    End Sub

    Private Sub LB(pa As String, el As ArrayList, hm As Long, tt As Boolean)
        Application.DoEvents()
        If tt Then
            P2.Maximum = el.Count
            P2.Value = 0
        End If
        For i As Long = 0 To el.Count - 1
            Dim elt As ArrayList = CType(el.Clone, ArrayList)
            Dim pat As String = pa & el(i).ToString
            For ii As Long = 0 To i
                elt.RemoveAt(0)
            Next
            If pat.Length \ 3 = eb.Count - hm Then
                If pat.Length > 3 OrElse pat <> "JJJ" Then
                    mst = 0
                    For ii As Long = 0 To pat.Length \ 3 - 1
                        If pat.Substring(ii * 3, 1) = "J" Then
                            mst += 30
                        Else
                            mst += CInt(pat.Substring(ii * 3 + 1, 2))
                        End If
                    Next
                    If mst > ms Then
                        Dim eltt As ArrayList = CType(ea.Clone, ArrayList)
                        For ix As Long = 0 To pat.Length \ 3 - 1
                            eltt.Add(pat.Substring(ix * 3, 3))
                        Next
                        Dim isCapable As Boolean = True
                        Dim icc1, icc2, icc3, icn As Boolean
                        Dim cct, cmt As String
                        Dim cnt As Long
                        For iii As Long = 0 To pat.Length \ 3 - 1
                            cct = pat.Substring(iii * 3, 1)
                            If Not cct = "J" Then
                                cmt = pat.Substring(iii * 3 + 1, 2)
                                cnt = CInt(pat.Substring(iii * 3 + 1, 2))
                                If cnt > 2 Then
                                    If cnt < 10 Then
                                        If eltt.Contains(cct & "0" & (cnt - 1)) AndAlso eltt.Contains(cct & "0" & (cnt - 2)) OrElse eltt.Contains(cct & "0" & (cnt - 1)) AndAlso eltt.Contains("JJJ") OrElse eltt.Contains("JJJ") AndAlso eltt.Contains(cct & "0" & (cnt - 2)) Then
                                            icc1 = True
                                        Else
                                            icc1 = False
                                        End If
                                    Else
                                        If eltt.Contains(cct & (cnt - 1)) AndAlso eltt.Contains(cct & (cnt - 2)) OrElse eltt.Contains(cct & (cnt - 1)) AndAlso eltt.Contains("JJJ") OrElse eltt.Contains("JJJ") AndAlso eltt.Contains(cct & (cnt - 2)) Then
                                            icc1 = True
                                        Else
                                            icc1 = False
                                        End If
                                    End If
                                Else
                                    icc1 = False
                                End If
                                If cnt > 1 AndAlso cnt < 13 Then
                                    If cnt < 10 Then
                                        If eltt.Contains(cct & "0" & (cnt - 1)) AndAlso eltt.Contains(cct & "0" & (cnt + 1)) OrElse eltt.Contains(cct & "0" & (cnt - 1)) AndAlso eltt.Contains("JJJ") OrElse eltt.Contains("JJJ") AndAlso eltt.Contains(cct & "0" & (cnt + 1)) Then
                                            icc2 = True
                                        Else
                                            icc2 = False
                                        End If
                                    Else
                                        If eltt.Contains(cct & (cnt - 1)) AndAlso eltt.Contains(cct & (cnt + 1)) OrElse eltt.Contains(cct & (cnt - 1)) AndAlso eltt.Contains("JJJ") OrElse eltt.Contains("JJJ") AndAlso eltt.Contains(cct & (cnt + 1)) Then
                                            icc2 = True
                                        Else
                                            icc2 = False
                                        End If
                                    End If
                                Else
                                    icc2 = False
                                End If
                                If cnt < 12 Then
                                    If cnt < 10 Then
                                        If eltt.Contains(cct & "0" & (cnt + 1)) AndAlso eltt.Contains(cct & "0" & (cnt + 2)) OrElse eltt.Contains(cct & "0" & (cnt + 1)) AndAlso eltt.Contains("JJJ") OrElse eltt.Contains("JJJ") AndAlso eltt.Contains(cct & "0" & (cnt + 2)) Then
                                            icc3 = True
                                        Else
                                            icc3 = False
                                        End If
                                    Else
                                        If eltt.Contains(cct & (cnt + 1)) AndAlso eltt.Contains(cct & (cnt + 2)) OrElse eltt.Contains(cct & (cnt + 1)) AndAlso eltt.Contains("JJJ") OrElse eltt.Contains("JJJ") AndAlso eltt.Contains(cct & (cnt + 2)) Then
                                            icc3 = True
                                        Else
                                            icc3 = False
                                        End If
                                    End If
                                Else
                                    icc3 = False
                                End If
                                Select Case cct
                                    Case "A"
                                        If eltt.Contains("B" & cmt) AndAlso eltt.Contains("C" & cmt) OrElse eltt.Contains("B" & cmt) AndAlso eltt.Contains("JJJ") Then
                                            icn = True
                                        Else
                                            If eltt.Contains("B" & cmt) AndAlso eltt.Contains("D" & cmt) OrElse eltt.Contains("C" & cmt) AndAlso eltt.Contains("JJJ") Then
                                                icn = True
                                            Else
                                                If eltt.Contains("C" & cmt) AndAlso eltt.Contains("D" & cmt) OrElse eltt.Contains("D" & cmt) AndAlso eltt.Contains("JJJ") Then
                                                    icn = True
                                                Else
                                                    icn = False
                                                End If
                                            End If
                                        End If
                                    Case "B"
                                        If eltt.Contains("A" & cmt) AndAlso eltt.Contains("C" & cmt) OrElse eltt.Contains("A" & cmt) AndAlso eltt.Contains("JJJ") Then
                                            icn = True
                                        Else
                                            If eltt.Contains("A" & cmt) AndAlso eltt.Contains("D" & cmt) OrElse eltt.Contains("C" & cmt) AndAlso eltt.Contains("JJJ") Then
                                                icn = True
                                            Else
                                                If eltt.Contains("C" & cmt) AndAlso eltt.Contains("D" & cmt) OrElse eltt.Contains("D" & cmt) AndAlso eltt.Contains("JJJ") Then
                                                    icn = True
                                                Else
                                                    icn = False
                                                End If
                                            End If
                                        End If
                                    Case "C"
                                        If eltt.Contains("A" & cmt) AndAlso eltt.Contains("B" & cmt) OrElse eltt.Contains("A" & cmt) AndAlso eltt.Contains("JJJ") Then
                                            icn = True
                                        Else
                                            If eltt.Contains("A" & cmt) AndAlso eltt.Contains("D" & cmt) OrElse eltt.Contains("B" & cmt) AndAlso eltt.Contains("JJJ") Then
                                                icn = True
                                            Else
                                                If eltt.Contains("B" & cmt) AndAlso eltt.Contains("D" & cmt) OrElse eltt.Contains("D" & cmt) AndAlso eltt.Contains("JJJ") Then
                                                    icn = True
                                                Else
                                                    icn = False
                                                End If
                                            End If
                                        End If
                                    Case "D"
                                        If eltt.Contains("A" & cmt) AndAlso eltt.Contains("B" & cmt) OrElse eltt.Contains("A" & cmt) AndAlso eltt.Contains("JJJ") Then
                                            icn = True
                                        Else
                                            If eltt.Contains("A" & cmt) AndAlso eltt.Contains("C" & cmt) OrElse eltt.Contains("B" & cmt) AndAlso eltt.Contains("JJJ") Then
                                                icn = True
                                            Else
                                                If eltt.Contains("B" & cmt) AndAlso eltt.Contains("C" & cmt) OrElse eltt.Contains("C" & cmt) AndAlso eltt.Contains("JJJ") Then
                                                    icn = True
                                                Else
                                                    icn = False
                                                End If
                                            End If
                                        End If
                                End Select
                                If icc1 OrElse icc2 OrElse icc3 OrElse icn Then
                                Else
                                    isCapable = False
                                End If
                            End If
                        Next
                        If isCapable Then
                            LA("", eltt, True)
                        End If
                    End If
                End If
            Else
                LB(pat, elt, hm, False)
            End If
            If tt Then
                P2.Value = i + 1
            End If
        Next
    End Sub

    Private Sub LA(pa As String, el As ArrayList, tt As Boolean)
        Application.DoEvents()
        If tt Then
            P3.Maximum = el.Count
            P3.Value = 0
        End If
        Dim isFinal As Boolean
        If el.Count = 1 Then
            isFinal = True
        End If
        For i As Long = 0 To el.Count - 1
            Dim elt As ArrayList = CType(el.Clone, ArrayList)
            Dim pat As String = pa & el(i).ToString
            elt.RemoveAt(i)
            If isFinal Then
                Dim ertx(35) As String
                LR(pat, 0, ertx)
            Else
                LA(pat, elt, False)
            End If
            If tt Then
                P3.Value = i + 1
            End If
        Next
    End Sub

    Private Sub LR(pa As String, lc As Long, ertx() As String)
        Dim ml As Long
        Dim pat As String
        Dim cc, cu As String
        Dim cn, cm As Long
        Dim ert(35), ers As String
        Dim wc As Boolean
        For i As Long = 0 To 35
            ert(i) = ertx(i)
        Next
        If pa.Length \ 3 < 13 Then
            ml = pa.Length \ 3
        Else
            ml = 13
        End If
        cc = ""
        For i As Long = 3 To ml
            ert(lc) = pa.Substring(0, i * 3)
            pat = pa.Substring(i * 3)
            For ixx As Long = lc + 1 To 35
                ert(ixx) = 0
            Next
            ers = ert(lc)
            wc = True
            cu = ""
            For ii As Long = 1 To ers.Length \ 3 - 1
                If ii = 1 Then
                    If ers.Substring(ii * 3 - 3, 1) = "J" Then
                        ii = 2
                        If ers.Substring(ii * 3 - 3, 1) = "J" Then
                            If ers.Length \ 3 > 3 Then
                                ii = 3
                                If ers.Substring(ii * 3 - 3, 1) = ers.Substring(ii * 3, 1) AndAlso CInt(ers.Substring(ii * 3 - 2, 2)) + 1 = CInt(ers.Substring(ii * 3 + 1, 2)) AndAlso CInt(ers.Substring(ii * 3 - 2, 2)) > 2 Then 'XXOO
                                    cm = 1
                                    cc = ers.Substring(ii * 3 - 3, 1)
                                    cn = CInt(ers.Substring(ii * 3 + 1, 2))
                                ElseIf i < 5 AndAlso ers.Substring(ii * 3 - 3, 1) <> ers.Substring(ii * 3, 1) AndAlso CInt(ers.Substring(ii * 3 - 2, 2)) = CInt(ers.Substring(ii * 3 + 1, 2)) Then
                                    cm = 2
                                    cn = CInt(ers.Substring(ii * 3 + 1, 2))
                                    cu &= ers.Substring(ii * 3 - 3, 1)
                                    cu &= ers.Substring(ii * 3, 1)
                                Else
                                    wc = False
                                    Exit For
                                End If
                            End If
                        ElseIf ers.Substring(ii * 3, 1) = "J" Then
                            If ers.Length \ 3 > 3 Then
                                ii = 3
                                If ers.Substring(ii * 3 - 6, 1) = ers.Substring(ii * 3, 1) AndAlso CInt(ers.Substring(ii * 3 - 5, 2)) + 2 = CInt(ers.Substring(ii * 3 + 1, 2)) AndAlso CInt(ers.Substring(ii * 3 - 5, 2)) > 1 Then 'XXOO
                                    cm = 1
                                    cc = ers.Substring(ii * 3 - 6, 1)
                                    cn = CInt(ers.Substring(ii * 3 + 1, 2))
                                ElseIf i < 5 AndAlso ers.Substring(ii * 3 - 6, 1) <> ers.Substring(ii * 3, 1) AndAlso CInt(ers.Substring(ii * 3 - 5, 2)) = CInt(ers.Substring(ii * 3 + 1, 2)) Then
                                    cm = 2
                                    cn = CInt(ers.Substring(ii * 3 + 1, 2))
                                    cu &= ers.Substring(ii * 3 - 6, 1)
                                    cu &= ers.Substring(ii * 3, 1)
                                Else
                                    wc = False
                                    Exit For
                                End If
                            End If
                        ElseIf ers.Substring(ii * 3 - 3, 1) = ers.Substring(ii * 3, 1) AndAlso CInt(ers.Substring(ii * 3 - 2, 2)) + 1 = CInt(ers.Substring(ii * 3 + 1, 2)) AndAlso CInt(ers.Substring(ii * 3 - 2, 2)) > 1 Then 'XOO
                            cm = 1
                            cc = ers.Substring(ii * 3 - 3, 1)
                            cn = CInt(ers.Substring(ii * 3 + 1, 2))
                        ElseIf i < 5 AndAlso ers.Substring(ii * 3 - 3, 1) <> ers.Substring(ii * 3, 1) AndAlso CInt(ers.Substring(ii * 3 - 2, 2)) = CInt(ers.Substring(ii * 3 + 1, 2)) Then
                            cm = 2
                            cn = CInt(ers.Substring(ii * 3 + 1, 2))
                            cu &= ers.Substring(ii * 3 - 3, 1)
                            cu &= ers.Substring(ii * 3, 1)
                        Else
                            wc = False
                            Exit For
                        End If
                    ElseIf ers.Substring(ii * 3, 1) = "J" Then
                        ii = 2
                        If ers.Substring(ii * 3, 1) = "J" Then
                            If ers.Length \ 3 > 3 Then
                                ii = 3
                                If ers.Substring(ii * 3 - 9, 1) = ers.Substring(ii * 3, 1) AndAlso CInt(ers.Substring(ii * 3 - 8, 2)) + 3 = CInt(ers.Substring(ii * 3 + 1, 2)) Then 'OXXO
                                    cm = 1
                                    cc = ers.Substring(ii * 3 - 9, 1)
                                    cn = CInt(ers.Substring(ii * 3 + 1, 2))
                                ElseIf i < 5 AndAlso ers.Substring(ii * 3 - 9, 1) <> ers.Substring(ii * 3, 1) AndAlso CInt(ers.Substring(ii * 3 - 8, 2)) = CInt(ers.Substring(ii * 3 + 1, 2)) Then
                                    cm = 2
                                    cn = CInt(ers.Substring(ii * 3 + 1, 2))
                                    cu &= ers.Substring(ii * 3 - 9, 1)
                                    cu &= ers.Substring(ii * 3, 1)
                                Else
                                    wc = False
                                    Exit For
                                End If
                            End If
                        ElseIf ers.Substring(ii * 3 - 6, 1) = ers.Substring(ii * 3, 1) AndAlso CInt(ers.Substring(ii * 3 - 5, 2)) + 2 = CInt(ers.Substring(ii * 3 + 1, 2)) Then 'OXO
                            cm = 1
                            cc = ers.Substring(ii * 3 - 6, 1)
                            cn = CInt(ers.Substring(ii * 3 + 1, 2))
                        ElseIf i < 5 AndAlso ers.Substring(ii * 3 - 6, 1) <> ers.Substring(ii * 3, 1) AndAlso CInt(ers.Substring(ii * 3 - 5, 2)) = CInt(ers.Substring(ii * 3 + 1, 2)) Then
                            cm = 2
                            cn = CInt(ers.Substring(ii * 3 + 1, 2))
                            cu &= ers.Substring(ii * 3 - 6, 1)
                            cu &= ers.Substring(ii * 3, 1)
                        Else
                            wc = False
                            Exit For
                        End If
                    ElseIf ers.Substring(ii * 3 - 3, 1) = ers.Substring(ii * 3, 1) AndAlso CInt(ers.Substring(ii * 3 - 2, 2)) + 1 = CInt(ers.Substring(ii * 3 + 1, 2)) Then 'OO
                        cm = 1
                        cc = ers.Substring(ii * 3 - 3, 1)
                        cn = CInt(ers.Substring(ii * 3 + 1, 2))
                    ElseIf i < 5 AndAlso ers.Substring(ii * 3 - 3, 1) <> ers.Substring(ii * 3, 1) AndAlso CInt(ers.Substring(ii * 3 - 2, 2)) = CInt(ers.Substring(ii * 3 + 1, 2)) Then
                        cm = 2
                        cn = CInt(ers.Substring(ii * 3 + 1, 2))
                        cu &= ers.Substring(ii * 3 - 3, 1)
                        cu &= ers.Substring(ii * 3, 1)
                    Else
                        wc = False
                        Exit For
                    End If
                Else
                    If cm = 1 Then
                        If ers.Substring(ii * 3, 1) = "J" Then
                            cn += 1
                            If cn = 14 Then
                                wc = False
                                Exit For
                            End If
                        ElseIf ers.Substring(ii * 3, 1) = cc AndAlso CInt(ers.Substring(ii * 3 + 1, 2)) = cn + 1 Then
                            cn += 1
                        Else
                            wc = False
                            Exit For
                        End If
                    ElseIf cm = 2 Then
                        If ers.Substring(ii * 3, 1) = "J" Then
                        ElseIf cu.Contains(ers.Substring(ii * 3, 1)) = False AndAlso CInt(ers.Substring(ii * 3 + 1, 2)) = cn Then
                            cu &= ers.Substring(ii * 3, 1)
                        Else
                            wc = False
                            Exit For
                        End If
                    End If
                End If
            Next
            If wc Then
                If pat = "" Then
                    ms = mst
                    er.Clear()
                    For iu As Long = 0 To 35
                        If ert(iu) <> "0" Then
                            er.Add(ert(iu))
                        End If
                    Next
                ElseIf pat.Length > 2 Then
                    LR(pat, lc + 1, ert)
                Else
                    Exit For
                End If
            Else
                Exit For
            End If
        Next
    End Sub
End Class