Public Class sched

    Private Sub sched_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(40, 40, 40)
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub BackToMainPanel(ByVal sender As Object, ByVal e As EventArgs)
        Panel1.Controls.Clear()

        ' Ibalik yung original controls (ListBox1, ListBox2, Enter Button, etc.)
        Panel1.Controls.Add(ListBox1)
        Panel1.Controls.Add(ListBox2)
        Panel1.Controls.Add(Button1)
        ' idagdag lahat ng controls na nasa Panel1 dati
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Check selections
        If ListBox1.SelectedIndex = -1 Or ListBox2.SelectedIndex = -1 Then
            MessageBox.Show("Please select both Course and Year Level!")
            Exit Sub
        End If

        Dim course As String = ListBox1.SelectedItem.ToString()
        Dim yearLevel As String = ListBox2.SelectedItem.ToString()

        ' Clear previous controls sa Panel
        Panel1.Controls.Clear()
        Panel1.Visible = True

        ' Example condition: BSIT + 1ST YEAR
        If course = "BSIT" And yearLevel = "1ST YEAR" Then
            Dim uc As New SC_BSIT1()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)

            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


            ' Halimbawa, BSIT + 2ND YEAR
        ElseIf course = "BSIT" And yearLevel = "2ND YEAR" Then
            Dim uc As New SC_BSIT2()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)

            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSIT" And yearLevel = "3RD YEAR" Then
            Dim uc As New SC_BSIT3()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)

            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSIT" And yearLevel = "4TH YEAR" Then
            Dim uc As New SC_BSIT4()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSCS" And yearLevel = "1ST YEAR" Then
            Dim uc As New SC_BSCS1()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSCS" And yearLevel = "2ND YEAR" Then
            Dim uc As New SC_BSCS2()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSCS" And yearLevel = "3RD YEAR" Then
            Dim uc As New SC_BSCS3()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSCS" And yearLevel = "4TH YEAR" Then
            Dim uc As New SC_BSCS4()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSIS" And yearLevel = "1ST YEAR" Then
            Dim uc As New SC_BSIS1()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSIS" And yearLevel = "2ND YEAR" Then
            Dim uc As New SC_BSIS2()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSIS" And yearLevel = "3RD YEAR" Then
            Dim uc As New SC_BSIS3()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSIS" And yearLevel = "4TH YEAR" Then
            Dim uc As New SC_BSIS4()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSCE" And yearLevel = "1ST YEAR" Then
            Dim uc As New SC_BSCE1()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSCE" And yearLevel = "2ND YEAR" Then
            Dim uc As New SC_BSCE2()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSCE" And yearLevel = "3RD YEAR" Then
            Dim uc As New SC_BSCE3()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)


        ElseIf course = "BSCE" And yearLevel = "4TH YEAR" Then
            Dim uc As New SC_BSCE4()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSMA" And yearLevel = "1ST YEAR" Then
            Dim uc As New SC_BSMA1()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSMA" And yearLevel = "2ND YEAR" Then
            Dim uc As New SC_BSMA2()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSMA" And yearLevel = "3RD YEAR" Then
            Dim uc As New SC_BSMA3()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)

        ElseIf course = "BSMA" And yearLevel = "4TH YEAR" Then
            Dim uc As New SC_BSMA4()
            uc.Dock = DockStyle.Fill
            Panel1.Controls.Add(uc)
            AddHandler uc.BackButtonClicked, AddressOf BackToMainPanel

            Panel1.Controls.Clear()
            Panel1.Controls.Add(uc)
        End If
    End Sub



    ' Optional handlers kung gusto mong may dagdag na action kapag pinili ang isang item
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ' Pwedeng dagdagan kung gusto mong mag-react agad pag nagselect ng Course
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        ' Pwedeng dagdagan kung gusto mong mag-react agad pag nagselect ng Year Level
    End Sub
End Class
