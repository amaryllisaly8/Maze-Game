Imports System.Media
Public Class Form1
    Dim bgPlayer As New SoundPlayer("C:\Users\lyngr\Downloads\paranormal-scream-sounds-31149.wav")
    ' Player para sa one-shot scream sounds
    Dim screamPlayer As New SoundPlayer()
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        bgPlayer.PlayLooping()

        Panel1.Size = New Size(959, 592)
        Panel1.Location = New Point(0, 0)
        Panel1.BringToFront()

        Panel2.Size = New Size(959, 592)
        Panel2.Location = New Point(0, 0)
        Panel2.Visible = False

        Panel3.Size = New Size(959, 592)
        Panel3.Location = New Point(0, 0)
        Panel3.Visible = False

        Panel4.Size = New Size(959, 592)
        Panel4.Location = New Point(0, 0)
        Panel4.Visible = False

        Panel5.Size = New Size(959, 592)
        Panel5.Location = New Point(0, 0)
        Panel5.Visible = False


    End Sub
    Public Sub New()
        Me.ClientSize = New Size(959, 592)
        Me.MinimumSize = Me.Size
        Me.MaximumSize = Me.Size
        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Finish_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Finish.MouseEnter
        MessageBox.Show("Level 1 Complete! Get ready for Medium Level.")
        Panel2.Visible = False
        Panel3.Visible = True
        MoveToStartPanel3()
    End Sub


    Private Sub MoveToStart()
        Dim StartingPoint = Panel2.Location()
        StartingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub

    Private Sub MoveToStartPanel3()
        Dim StartingPoint = Panel3.Location()
        StartingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub

    Private Sub MoveToStartPanel4()
        Dim StartingPoint = Panel4.Location()
        StartingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub

    Private Sub Wall_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.MouseEnter, Panel2.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label6.MouseEnter, Label59.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label28.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        MoveToStart()
    End Sub


    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Panel1.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub Wall2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label99.MouseEnter, Label97.MouseEnter, Label96.MouseEnter, Label95.MouseEnter, Label94.MouseEnter, Label93.MouseEnter, Label92.MouseEnter, Label90.MouseEnter, Label89.MouseEnter, Label88.MouseEnter, Label87.MouseEnter, Label86.MouseEnter, Label85.MouseEnter, Label84.MouseEnter, Label83.MouseEnter, Label82.MouseEnter, Label81.MouseEnter, Label80.MouseEnter, Label79.MouseEnter, Label78.MouseEnter, Label77.MouseEnter, Label76.MouseEnter, Label75.MouseEnter, Label74.MouseEnter, Label73.MouseEnter, Label71.MouseEnter, Label70.MouseEnter, Label69.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label64.MouseEnter, Label127.MouseEnter, Label126.MouseEnter, Label125.MouseEnter, Label124.MouseEnter, Label123.MouseEnter, Label122.MouseEnter, Label121.MouseEnter, Label120.MouseEnter, Label119.MouseEnter, Label118.MouseEnter, Label117.MouseEnter, Label116.MouseEnter, Label115.MouseEnter, Label114.MouseEnter, Label113.MouseEnter, Label112.MouseEnter, Label111.MouseEnter, Label110.MouseEnter, Label109.MouseEnter, Label108.MouseEnter, Label107.MouseEnter, Label106.MouseEnter, Label105.MouseEnter, Label104.MouseEnter, Label103.MouseEnter, Label102.MouseEnter, Label101.MouseEnter, Label100.MouseEnter
        MoveToStartPanel3()
    End Sub

    Private Sub Finish2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Finish2.MouseEnter
        MessageBox.Show("Level 2 Complete! Now the Hard Level begins!")
        Panel3.Visible = False
        Panel4.Visible = True
        MoveToStartPanel4()

    End Sub
    Private Sub Finish3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Finish3.MouseEnter
        Panel4.Visible = False
        Panel5.Visible = True
     
        ' I-set ang tunog gamit ang full path
        screamPlayer.SoundLocation = "C:\Users\lyngr\Downloads\New Project (1).wav"

        ' I-load muna ang file bago i-play
        screamPlayer.Load()

        ' I-play ang tunog
        screamPlayer.Play()
    End Sub

    Private Sub Wall3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label68.MouseEnter, Label193.MouseEnter, Label192.MouseEnter, Label191.MouseEnter, Label190.MouseEnter, Label189.MouseEnter, Label188.MouseEnter, Label187.MouseEnter, Label186.MouseEnter, Label185.MouseEnter, Label184.MouseEnter, Label183.MouseEnter, Label182.MouseEnter, Label181.MouseEnter, Label180.MouseEnter, Label179.MouseEnter, Label178.MouseEnter, Label177.MouseEnter, Label176.MouseEnter, Label175.MouseEnter, Label174.MouseEnter, Label173.MouseEnter, Label172.MouseEnter, Label171.MouseEnter, Label170.MouseEnter, Label169.MouseEnter, Label168.MouseEnter, Label167.MouseEnter, Label166.MouseEnter, Label165.MouseEnter, Label164.MouseEnter, Label163.MouseEnter, Label162.MouseEnter, Label161.MouseEnter, Label160.MouseEnter, Label159.MouseEnter, Label158.MouseEnter, Label157.MouseEnter, Label156.MouseEnter, Label155.MouseEnter, Label154.MouseEnter, Label153.MouseEnter, Label152.MouseEnter, Label151.MouseEnter, Label150.MouseEnter, Label149.MouseEnter, Label148.MouseEnter, Label147.MouseEnter, Label146.MouseEnter, Label145.MouseEnter, Label144.MouseEnter, Label143.MouseEnter, Label142.MouseEnter, Label141.MouseEnter, Label140.MouseEnter, Label139.MouseEnter, Label138.MouseEnter, Label137.MouseEnter, Label136.MouseEnter, Label135.MouseEnter, Label134.MouseEnter, Label133.MouseEnter, Label131.MouseEnter, Label130.MouseEnter, Label129.MouseEnter, Label128.MouseEnter
        MoveToStartPanel4()
    End Sub
End Class
