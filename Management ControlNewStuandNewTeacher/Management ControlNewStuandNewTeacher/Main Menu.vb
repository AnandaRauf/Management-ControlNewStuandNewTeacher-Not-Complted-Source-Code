Public Class Main_Menu
    Private Sub AboutAppsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutAppsToolStripMenuItem.Click
        MessageBox.Show("Version 1.0.0")
        MessageBox.Show("Powered  By PT.Tech Media Development")
        MessageBox.Show("Developed Date: 03 January 2019")
    End Sub

    Private Sub InstagramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstagramToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.instagram.com/anandarauf02/")
    End Sub

    Private Sub Instagram2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Facebook1ToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.instagram.com/anandarauf08/")
    End Sub

    Private Sub FacebookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Facebook2ToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/chiefexecutiveofficeroftmd/")
    End Sub

    Private Sub Facebook2ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InstagramToolStripMenuItem2.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/CEOTechMediaDevelopment")
    End Sub

    Private Sub InstagramToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InstagramToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("https://www.instagram.com/tmd.indo")
    End Sub
End Class