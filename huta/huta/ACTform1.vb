Public Class ACTForm1

    Private Sub BSITform1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'subject code disable section in tagalog lugar ng mga pwd'
        chk7.Enabled = False
        chkcomso02a.Enabled = False
        chk14.Enabled = False
        chkcompo004.Enabled = False
        chk8.Enabled = False
        chkengl02a.Enabled = False
        chk15.Enabled = False
        chkengl003.Enabled = False
        chk9.Enabled = False
        chkfil02.Enabled = False
        chk10.Enabled = False
        chkmath201.Enabled = False
        CheckBox6.Enabled = False
        chk12.Enabled = False
        chkphye002.Enabled = False
        chk19.Enabled = False
        chkphye003.Enabled = False
        chk20.Enabled = False
        chknstp2.Enabled = False
        chkcomso3.Enabled = False
        CheckBox34.Enabled = False
        CheckBox28.Enabled = False
        chkitweb.Enabled = False
        CheckBox22.Enabled = False
        chkfil03.Enabled = False
        CheckBox34.Enabled = False
        chkpe4.Enabled = False
        CheckBox11.Enabled = False
        chkphyso01.Enabled = False
        CheckBox2.Enabled = False
        chkcomso04.Enabled = False
        CheckBox8.Enabled = False
        chketron01.Enabled = False
        CheckBox18.Enabled = False
        chkmath206.Enabled = False
        CheckBox23.Enabled = False
        chkmath203.Enabled = False
        CheckBox24.Enabled = False
        chkitcomso8.Enabled = False
        CheckBox39.Enabled = False
        chkcomso05.Enabled = False
        CheckBox35.Enabled = False
        chkcisco001.Enabled = False
        CheckBox29.Enabled = False
        chkelect001.Enabled = False
        CheckBox17.Enabled = False
        chkipoo1.Enabled = False
        CheckBox6.Enabled = False
    End Sub
    'adding subject to listbox and units to unitbox code section in tagalog bading si jayvee antazo'
    Private Sub chkcompo01_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcompo01.CheckedChanged

        If chkcompo01.Checked = True Then
            ListBoxSubject.Items.Add("COMPO01")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("COMPO01")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If

    End Sub

    Private Sub chkmkey001_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmkey001.CheckedChanged

        If chkmkey001.Checked = True Then
            ListBoxSubject.Items.Add("MKEY001")
            boxunit.Text = "4"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("MKEY001")
            listboxunit.Items.Remove("4")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 4
        End If
    End Sub

    Private Sub chkeng01a_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkeng01a.CheckedChanged
        If chkeng01a.Checked = True Then
            ListBoxSubject.Items.Add("ENGL001")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("ENGL001")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chkfil01_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfil01.CheckedChanged

        If chkfil01.Checked = True Then
            ListBoxSubject.Items.Add("FIL-01")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("FIL-01")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chkmath002_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmath002.CheckedChanged

        If chkmath002.Checked = True Then
            ListBoxSubject.Items.Add("MATH002")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("MATH002")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chkphye001_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkphye001.CheckedChanged

        If chkphye001.Checked = True Then
            ListBoxSubject.Items.Add("PHYE001")
            boxunit.Text = "2"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("PHYE001")
            listboxunit.Items.Remove("2")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 2
        End If
    End Sub
    'sign-out code section in tagalog iiwan ka din nya, walang forever'
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignout.Click
        If MessageBox.Show("Sign-out?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.Hide()
            Form1.Show()
            Form1.txtUsername.Clear()
            Form1.txtPassword.Clear()
        End If
    End Sub

    Private Sub chkcomso02a_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcomso02a.CheckedChanged

        If chkcomso02a.Checked = True Then
            ListBoxSubject.Items.Add("COMPO01")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("COMPO01")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If


    End Sub

    Private Sub chkengl02a_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkengl02a.CheckedChanged

        If chkengl02a.Checked = True Then
            ListBoxSubject.Items.Add("ENGL02A")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("ENGL02A")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chkfil02_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfil02.CheckedChanged

        If chkfil02.Checked = True Then
            ListBoxSubject.Items.Add("FIL-02")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("FIL-02")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chkmath201_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmath201.CheckedChanged

        If chkmath201.Enabled Then
            ListBoxSubject.Items.Add("MATH201")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("MATH201")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chksosci01_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksosci01.CheckedChanged

        If chksosci01.Checked = True Then
            ListBoxSubject.Items.Add("SOSCI01")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("SOSCI01")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chkphye002_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkphye002.CheckedChanged

        If chkphye002.Checked = True Then
            ListBoxSubject.Items.Add("PHYE002")
            boxunit.Text = "2"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("PHYE002")
            listboxunit.Items.Remove("2")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 2
        End If
    End Sub

    Private Sub chknstp1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknstp1.CheckedChanged

        If chknstp1.Checked = True Then
            ListBoxSubject.Items.Add("NSTP-1")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("NSTP-1")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chkcompo004_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcompo004.CheckedChanged

        If chkcompo004.Checked = True Then
            ListBoxSubject.Items.Add("COMPO004")
            boxunit.Text = "4"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("COMPO004")
            listboxunit.Items.Remove("4")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 4
        End If
    End Sub

    Private Sub chkengl003_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkengl003.CheckedChanged

        If chkengl003.Checked = True Then
            ListBoxSubject.Items.Add("ENGL003")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("ENGL003")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chkrizal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkrizal.CheckedChanged

        If chkrizal.Checked = True Then
            ListBoxSubject.Items.Add("RIZALCRS")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("RIZALCRS")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chksosci04_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksosci04.CheckedChanged

        If chksosci04.Checked = True Then
            ListBoxSubject.Items.Add("SOSCI04")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("SOSCI04")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chkvalu01a_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkvalu01a.CheckedChanged

        If chkvalu01a.Checked = True Then
            ListBoxSubject.Items.Add("VALU01A")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("VALU01A")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chkphye003_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkphye003.CheckedChanged

        If chkphye003.Checked = True Then
            ListBoxSubject.Items.Add("PHYE003")
            boxunit.Text = "2"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("PHYE003")
            listboxunit.Items.Remove("2")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 2
        End If
    End Sub

    Private Sub chknstp2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chknstp2.CheckedChanged

        If chknstp2.Checked = True Then
            ListBoxSubject.Items.Add("NSTP-2")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("NSTP-2")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub
    'prerikuset code basta sa tagalog mauna-una'
    Private Sub chk1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1.CheckedChanged
        If chk1.Checked = True Then
            chkcompo01.Enabled = False
            chkcompo01.Checked = False
        Else
            chkcompo01.Enabled = True
        End If
    End Sub

    Private Sub chk2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk2.CheckedChanged
        If chk2.Checked = True Then
            chkmkey001.Enabled = False
            chkmkey001.Checked = False
            chk7.Enabled = True
            chkcomso02a.Enabled = True
            chk14.Enabled = True
            chkcompo004.Enabled = True
        ElseIf chk2.Checked = False Then
            chkmkey001.Enabled = True
            chk7.Enabled = False
            chkcomso02a.Enabled = False
            chk14.Enabled = False
            chkcompo004.Enabled = False

        End If
    End Sub

    Private Sub chk3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk3.CheckedChanged
        If chk3.Checked = True Then
            chkeng01a.Enabled = False
            chkeng01a.Checked = False
            chk8.Enabled = True
            chkengl02a.Enabled = True
            chk15.Enabled = True
            chkengl003.Enabled = True
        Else
            chkeng01a.Enabled = True
            chk8.Enabled = False
            chkengl02a.Enabled = False
            chk15.Enabled = False
            chkengl003.Enabled = False

        End If
    End Sub

    Private Sub chk4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk4.CheckedChanged
        If chk4.Checked = True Then
            chkfil01.Enabled = False
            chkfil01.Checked = False
            chk9.Enabled = True
            chkfil02.Enabled = True
        Else
            chkfil01.Enabled = True
            chk9.Enabled = False
            chkfil02.Enabled = False
        End If
    End Sub

    Private Sub chk5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk5.CheckedChanged
        If chk5.Checked = True Then
            chkmath002.Enabled = False
            chkmath002.Checked = False
            chk10.Enabled = True
            chkmath201.Enabled = True
        Else
            chkmath002.Enabled = True
            chk10.Enabled = False
            chkmath201.Enabled = False
        End If
    End Sub

    Private Sub chk6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk6.CheckedChanged
        If chk6.Checked = True Then
            chkphye001.Enabled = False
            chkphye001.Checked = False
            chk12.Enabled = True
            chkphye002.Enabled = True
        Else
            chkphye001.Enabled = True
            chk12.Enabled = False
            chkphye002.Enabled = False
        End If
    End Sub

    Private Sub chk7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk7.CheckedChanged
        If chk7.Checked = True Then
            chkcomso02a.Enabled = False
            chkcomso02a.Checked = False
            chkcomso3.Enabled = True
            CheckBox34.Enabled = True
            CheckBox28.Enabled = True
            chkitweb.Enabled = True
        Else
            chkcomso02a.Enabled = True
            chkcomso3.Enabled = False
            CheckBox34.Enabled = False
            CheckBox28.Enabled = False
            chkitweb.Enabled = False
        End If
    End Sub

    Private Sub chk8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk8.CheckedChanged
        If chk8.Checked = True Then
            chkengl02a.Enabled = False
            chkengl02a.Checked = False
        Else
            chkengl02a.Enabled = True
        End If
    End Sub

    Private Sub chk9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk9.CheckedChanged
        If chk9.Checked = True Then
            chkfil02.Enabled = False
            chkfil02.Checked = False
            CheckBox22.Enabled = True
            chkfil03.Enabled = True
        Else
            chkfil02.Enabled = True
            CheckBox22.Enabled = False
            chkfil03.Enabled = False
        End If
    End Sub

    Private Sub chk10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk10.CheckedChanged
        If chk10.Checked = True Then
            chkmath201.Enabled = False
            chkmath201.Checked = False
            CheckBox11.Enabled = True
            chkphyso01.Enabled = True
            CheckBox18.Enabled = True
            chkmath206.Enabled = True
            CheckBox23.Enabled = True
            chkmath203.Enabled = True
        Else
            chkmath201.Enabled = True
            CheckBox11.Enabled = False
            chkphyso01.Enabled = False
            CheckBox18.Enabled = False
            chkmath206.Enabled = False
            CheckBox23.Enabled = False
            chkmath203.Enabled = False
        End If
    End Sub

    Private Sub chk11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk11.CheckedChanged
        If chk11.Checked = True Then
            chksosci01.Enabled = False
            chksosci01.Checked = False
        Else
            chksosci01.Enabled = True

        End If
    End Sub

    Private Sub chk12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk12.CheckedChanged
        If chk12.Checked = True Then
            chkphye002.Enabled = False
            chkphye002.Checked = False
            chk19.Enabled = True
            chkphye003.Enabled = True
        Else
            chkphye002.Enabled = True
            chk19.Enabled = False
            chkphye003.Enabled = False
        End If
    End Sub

    Private Sub chk13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk13.CheckedChanged
        If chk13.Checked = True Then
            chknstp1.Enabled = False
            chknstp1.Checked = False
            chk20.Enabled = True
            chknstp2.Enabled = True
        Else
            chknstp1.Enabled = True
            chk20.Enabled = False
            chknstp2.Enabled = False
        End If
    End Sub

    Private Sub chk14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk14.CheckedChanged
        If chk14.Checked = True Then
            chkcompo004.Enabled = False
            chkcompo004.Checked = False
        Else
            chkcompo004.Enabled = True
        End If
    End Sub

    Private Sub chk15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk15.CheckedChanged
        If chk15.Checked = True Then
            chkengl003.Enabled = False
            chkengl003.Checked = False
        Else
            chkengl003.Enabled = True
        End If
    End Sub

    Private Sub chk16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk16.CheckedChanged
        If chk16.Checked = True Then
            chkrizal.Enabled = False
            chkrizal.Checked = False
        Else
            chkrizal.Enabled = True
        End If
    End Sub

    Private Sub chk17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk17.CheckedChanged
        If chk17.Checked = True Then
            chksosci04.Enabled = False
            chksosci04.Checked = False
        Else
            chksosci04.Enabled = True
        End If
    End Sub

    Private Sub chk18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk18.CheckedChanged
        If chk18.Checked = True Then
            chkvalu01a.Enabled = False
            chkvalu01a.Checked = False
        Else
            chkvalu01a.Enabled = True
        End If
    End Sub

    Private Sub chk19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk19.CheckedChanged
        If chk19.Checked = True Then
            chkphye003.Enabled = False
            chkphye003.Checked = False
            CheckBox6.Enabled = True
            chkpe4.Enabled = True
        Else
            chkphye003.Enabled = True
            CheckBox6.Enabled = False
            chkpe4.Enabled = False

        End If
    End Sub

    Private Sub chk20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk20.CheckedChanged
        If chk20.Checked = True Then
            chknstp2.Enabled = False
            chknstp2.Checked = False
        Else
            chknstp2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBoxSubject.Items.Clear()
        listboxunit.Items.Clear()
        boxunit.Clear()
        txtboxTotal.Clear()
        txtResult.Clear()

    End Sub

    Private Sub CheckBox34_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox34.CheckedChanged
        If CheckBox34.Checked Then
            chkcomso3.Enabled = False
            chkcomso3.Checked = False
            CheckBox2.Enabled = True
            chkcomso04.Enabled = True
            CheckBox17.Enabled = True
            chkipoo1.Enabled = True
        Else
            chkcomso3.Enabled = True
            CheckBox2.Enabled = False
            chkcomso04.Enabled = False
            CheckBox17.Enabled = False
            chkipoo1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox28_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox28.CheckedChanged
        If CheckBox28.Checked Then
            chkitweb.Enabled = False
            chkitweb.Checked = False
            CheckBox24.Enabled = True
            chkitcomso8.Enabled = True
            CheckBox17.Enabled = True
            chkipoo1.Enabled = True
        Else
            chkitweb.Enabled = True
            CheckBox24.Enabled = False
            chkitcomso8.Enabled = False
            CheckBox17.Enabled = False
            chkipoo1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked Then
            chkfil03.Enabled = False
            chkfil03.Checked = False
            CheckBox17.Enabled = True
            chkipoo1.Enabled = True
        Else
            chkfil03.Enabled = True
            CheckBox17.Enabled = False
            chkipoo1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked Then
            chklite001.Enabled = False
            chklite001.Checked = False
        Else
            chklite001.Enabled = True
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked Then
            chkphyso01.Enabled = False
            chkphyso01.Checked = False
            CheckBox8.Enabled = True
            chketron01.Enabled = True
            CheckBox17.Enabled = True
            chkipoo1.Enabled = True
        Else
            chkphyso01.Enabled = True
            CheckBox8.Enabled = False
            chketron01.Enabled = False
            CheckBox17.Enabled = False
            chkipoo1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            chkpe4.Enabled = False
            chkpe4.Checked = False
        Else
            chkpe4.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            chkcomso04.Enabled = False
            chkcomso04.Checked = False
            CheckBox39.Enabled = True
            chkcomso05.Enabled = True
        Else
            chkcomso04.Enabled = True
            CheckBox39.Enabled = False
            chkcomso05.Enabled = False
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked Then
            chketron01.Enabled = False
            chketron01.Checked = False
            CheckBox35.Enabled = True
            chkcisco001.Enabled = True
            CheckBox29.Enabled = True
            chkelect001.Enabled = True
        Else
            chketron01.Enabled = True
            CheckBox35.Enabled = False
            chkcisco001.Enabled = False
            CheckBox29.Enabled = False
            chkelect001.Enabled = False
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked Then
            chkecon001.Enabled = False
            chkecon001.Checked = False
        Else
            chkecon001.Enabled = True
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked Then
            chkmath206.Enabled = False
            chkmath206.Checked = False
        Else
            chkmath206.Enabled = True
        End If
    End Sub

    Private Sub CheckBox24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked Then
            chkitcomso8.Enabled = False
            chkitcomso8.Checked = False
        Else
            chkitcomso8.Enabled = True
        End If
    End Sub

    Private Sub CheckBox39_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox39.CheckedChanged
        If CheckBox39.Checked Then
            chkcomso05.Enabled = False
            chkcomso05.Checked = False
        Else
            chkcomso05.Enabled = True
        End If
    End Sub

    Private Sub CheckBox35_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox35.CheckedChanged
        If CheckBox35.Checked Then
            chkcisco001.Enabled = False
            chkcisco001.Checked = False
        Else
            chkcisco001.Enabled = True
        End If
    End Sub

    Private Sub CheckBox29_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox29.CheckedChanged
        If CheckBox29.Checked Then
            chkelect001.Enabled = False
            chkelect001.Checked = False
        Else
            chkelect001.Enabled = True
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked Then
            chkipoo1.Enabled = False
            chkipoo1.Checked = False
        Else
            chkipoo1.Enabled = True
        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked Then
            chkmath203.Enabled = False
            chkmath203.Checked = False
        Else
            chkmath203.Enabled = True
        End If
    End Sub
    'bading din si jb sison skl'
    Private Sub chkcomso3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcomso3.CheckedChanged

        If chkcomso3.Checked Then
            ListBoxSubject.Items.Add("COMSO03")
            boxunit.Text = "4"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("COMSO03")
            listboxunit.Items.Remove("4")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 4
        End If
    End Sub
    Private Sub chkitweb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkitweb.CheckedChanged

        If chkitweb.Checked Then
            ListBoxSubject.Items.Add("ITWEB")
            boxunit.Text = "4"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("ITWEB")
            listboxunit.Items.Remove("4")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 4
        End If
    End Sub

    Private Sub chkfil03_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfil03.CheckedChanged

        If chkfil03.Checked Then
            ListBoxSubject.Items.Add("FIL-03")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("FIL-03")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chklite001_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklite001.CheckedChanged

        If chklite001.Checked Then
            ListBoxSubject.Items.Add("LITE001")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("LITE001")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chkphyso01_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkphyso01.CheckedChanged

        If chkphyso01.Checked Then
            ListBoxSubject.Items.Add("PHYSO01")
            boxunit.Text = "4"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("PHYSO01")
            listboxunit.Items.Remove("4")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 4
        End If
    End Sub

    Private Sub chkpe4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpe4.CheckedChanged

        If chkpe4.Checked Then
            ListBoxSubject.Items.Add("PHYE004")
            boxunit.Text = "2"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("PHYE004")
            listboxunit.Items.Remove("2")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 2
        End If
    End Sub

    Private Sub chkcomso04_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcomso04.CheckedChanged

        If chkcomso04.Checked Then
            ListBoxSubject.Items.Add("COMSO04")
            boxunit.Text = "4"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("COMSO04")
            listboxunit.Items.Remove("4")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 4
        End If
    End Sub

    Private Sub chketron01_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chketron01.CheckedChanged

        If chketron01.Checked Then
            ListBoxSubject.Items.Add("ETRON01")
            boxunit.Text = "4"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("ETRON01")
            listboxunit.Items.Remove("4")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 4
        End If
    End Sub

    Private Sub chkecon001_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkecon001.CheckedChanged
        If chkecon001.Checked Then
            ListBoxSubject.Items.Add("ECON001")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("ECON001")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chkmath206_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmath206.CheckedChanged

        If chkmath206.Checked Then
            ListBoxSubject.Items.Add("MATH206")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("MATH206")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chkitcomso8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkitcomso8.CheckedChanged

        If chkitcomso8.Checked Then
            ListBoxSubject.Items.Add("ITCOMSO8")
            boxunit.Text = "4"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("ITCOMSO8")
            listboxunit.Items.Remove("4")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 4
        End If
    End Sub

    Private Sub chkcomso05_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcomso05.CheckedChanged

        If chkcomso05.Checked Then
            ListBoxSubject.Items.Add("COMSO05")
            boxunit.Text = "4"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("COMSO05")
            listboxunit.Items.Remove("4")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 4
        End If
    End Sub

    Private Sub chkcisco001_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcisco001.CheckedChanged

        If chkcisco001.Checked Then
            ListBoxSubject.Items.Add("CISCO001")
            boxunit.Text = "4"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("CISCO001")
            listboxunit.Items.Remove("4")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 4
        End If
    End Sub

    Private Sub chkelect001_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkelect001.CheckedChanged

        If chkelect001.Checked Then
            ListBoxSubject.Items.Add("ELECT001")
            boxunit.Text = "4"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("ELECT001")
            listboxunit.Items.Remove("4")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 4
        End If
    End Sub

    Private Sub chkmath203_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmath203.CheckedChanged

        If chkmath203.Checked Then
            ListBoxSubject.Items.Add("MATH203")
            boxunit.Text = "3"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("MATH203")
            listboxunit.Items.Remove("3")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 3
        End If
    End Sub

    Private Sub chkipoo1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkipoo1.CheckedChanged

        If chkipoo1.Checked Then
            MsgBox("Note: This subject is only available for Second Year Standing.")
            ListBoxSubject.Items.Add("IPOO1")
            boxunit.Text = "6"
            listboxunit.Items.Add(boxunit.Text)
            txtboxTotal.Text = Val(boxunit.Text) + Val(txtboxTotal.Text)
            boxunit.Text = ""
        Else
            ListBoxSubject.Items.Remove("IPOO1")
            listboxunit.Items.Remove("6")
            boxunit.Text = ""
            txtboxTotal.Text = Val(txtboxTotal.Text) - 6
        End If
    End Sub
    'validating the number of unit code section in tagalog papaasahin ka lang pala nya.'
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtboxTotal.Text = "" Then
            MsgBox("Add Subject/s First")
        ElseIf txtboxTotal.Text = 0 Then
            MsgBox("Add Subject/s First")
        ElseIf txtboxTotal.Text >= 22 Then
            txtResult.Text = "DECLINE"
            txtResult.ForeColor = Color.Red
            MsgBox("21 is the maximum unit per trimester, Remove some Subjects")
        Else
            txtResult.Text = "APPROVE"
            txtResult.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnSA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSA.Click
        Subjectavailable.Show()
    End Sub

End Class