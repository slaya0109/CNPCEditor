''' <summary>
''' テキスト編集画面フォームクラス
''' </summary>
''' <remarks></remarks>
Public Class TextEditForm
    Public textData As TextClass

    Sub New(ReceiveTextData As TextClass)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        Me.textData = ReceiveTextData
    End Sub

    Private Sub TextEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetCmbSkill8()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.textData = CreateTextClassData()

        MainForm.SendTextData = Me.textData

        Me.Close()
    End Sub

#Region "待機・戦闘状態関連イベントメソッド"
    Private Sub btnAddCalm1_Click(sender As Object, e As EventArgs) Handles btnAddCalm1.Click
        Try
            Me.dgvCalm1.Rows.Add()
            Me.dgvCalm1.Rows(Me.dgvCalm1.RowCount - 1).Cells(0).Value = Me.txtCalm1.Text
            Me.txtCalm1.Text = ""
            Me.txtCalm1.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm1_Click(sender As Object, e As EventArgs) Handles btnDelCalm1.Click
        Try
            If Me.dgvCalm1.RowCount > 0 Then
                Me.dgvCalm1.Rows.RemoveAt(Me.dgvCalm1.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm2_Click(sender As Object, e As EventArgs) Handles btnAddCalm2.Click
        Try
            Me.dgvCalm2.Rows.Add()
            Me.dgvCalm2.Rows(Me.dgvCalm2.RowCount - 1).Cells(0).Value = Me.txtCalm2.Text
            Me.txtCalm2.Text = ""
            Me.txtCalm2.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm2_Click(sender As Object, e As EventArgs) Handles btnDelCalm2.Click
        Try
            If Me.dgvCalm2.RowCount > 0 Then
                Me.dgvCalm2.Rows.RemoveAt(Me.dgvCalm2.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm3_Click(sender As Object, e As EventArgs) Handles btnAddCalm3.Click
        Try
            Me.dgvCalm3.Rows.Add()
            Me.dgvCalm3.Rows(Me.dgvCalm3.RowCount - 1).Cells(0).Value = Me.txtCalm3.Text
            Me.txtCalm3.Text = ""
            Me.txtCalm3.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm3_Click(sender As Object, e As EventArgs) Handles btnDelCalm3.Click
        Try
            If Me.dgvCalm3.RowCount > 0 Then
                Me.dgvCalm3.Rows.RemoveAt(Me.dgvCalm3.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm4_Click(sender As Object, e As EventArgs) Handles btnAddCalm4.Click
        Try
            Me.dgvCalm4.Rows.Add()
            Me.dgvCalm4.Rows(Me.dgvCalm4.RowCount - 1).Cells(0).Value = Me.txtCalm4.Text
            Me.txtCalm4.Text = ""
            Me.txtCalm4.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm4_Click(sender As Object, e As EventArgs) Handles btnDelCalm4.Click
        Try
            If Me.dgvCalm4.RowCount > 0 Then
                Me.dgvCalm4.Rows.RemoveAt(Me.dgvCalm4.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm5_Click(sender As Object, e As EventArgs) Handles btnAddCalm5.Click
        Try
            Me.dgvCalm5.Rows.Add()
            Me.dgvCalm5.Rows(Me.dgvCalm5.RowCount - 1).Cells(0).Value = Me.txtCalm5.Text
            Me.txtCalm5.Text = ""
            Me.txtCalm5.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm5_Click(sender As Object, e As EventArgs) Handles btnDelCalm5.Click
        Try
            If Me.dgvCalm5.RowCount > 0 Then
                Me.dgvCalm5.Rows.RemoveAt(Me.dgvCalm5.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm6_Click(sender As Object, e As EventArgs) Handles btnAddCalm6.Click
        Try
            Me.dgvCalm6.Rows.Add()
            Me.dgvCalm6.Rows(Me.dgvCalm6.RowCount - 1).Cells(0).Value = Me.txtCalm6.Text
            Me.txtCalm6.Text = ""
            Me.txtCalm6.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm6_Click(sender As Object, e As EventArgs) Handles btnDelCalm6.Click
        Try
            If Me.dgvCalm6.RowCount > 0 Then
                Me.dgvCalm6.Rows.RemoveAt(Me.dgvCalm6.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm7_Click(sender As Object, e As EventArgs) Handles btnAddCalm7.Click
        Try
            Me.dgvCalm7.Rows.Add()
            Me.dgvCalm7.Rows(Me.dgvCalm7.RowCount - 1).Cells(0).Value = Me.txtCalm7.Text
            Me.txtCalm7.Text = ""
            Me.txtCalm7.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm7_Click(sender As Object, e As EventArgs) Handles btnDelCalm7.Click
        Try
            If Me.dgvCalm7.RowCount > 0 Then
                Me.dgvCalm7.Rows.RemoveAt(Me.dgvCalm7.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm8_Click(sender As Object, e As EventArgs) Handles btnAddCalm8.Click
        Try
            Me.dgvCalm8.Rows.Add()
            Me.dgvCalm8.Rows(Me.dgvCalm8.RowCount - 1).Cells(0).Value = Me.txtCalm8.Text
            Me.txtCalm8.Text = ""
            Me.txtCalm8.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm8_Click(sender As Object, e As EventArgs) Handles btnDelCalm8.Click
        Try
            If Me.dgvCalm8.RowCount > 0 Then
                Me.dgvCalm8.Rows.RemoveAt(Me.dgvCalm8.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm9_Click(sender As Object, e As EventArgs) Handles btnAddCalm9.Click
        Try
            Me.dgvCalm9.Rows.Add()
            Me.dgvCalm9.Rows(Me.dgvCalm9.RowCount - 1).Cells(0).Value = Me.txtCalm9.Text
            Me.txtCalm9.Text = ""
            Me.txtCalm9.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm9_Click(sender As Object, e As EventArgs) Handles btnDelCalm9.Click
        Try
            If Me.dgvCalm9.RowCount > 0 Then
                Me.dgvCalm9.Rows.RemoveAt(Me.dgvCalm9.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm10_Click(sender As Object, e As EventArgs) Handles btnAddCalm10.Click
        Try
            Me.dgvCalm10.Rows.Add()
            Me.dgvCalm10.Rows(Me.dgvCalm10.RowCount - 1).Cells(0).Value = Me.txtCalm10.Text
            Me.txtCalm10.Text = ""
            Me.txtCalm10.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm10_Click(sender As Object, e As EventArgs) Handles btnDelCalm10.Click
        Try
            If Me.dgvCalm10.RowCount > 0 Then
                Me.dgvCalm10.Rows.RemoveAt(Me.dgvCalm10.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm11_Click(sender As Object, e As EventArgs) Handles btnAddCalm11.Click
        Try
            Me.dgvCalm11.Rows.Add()
            Me.dgvCalm11.Rows(Me.dgvCalm11.RowCount - 1).Cells(0).Value = Me.txtCalm11.Text
            Me.txtCalm11.Text = ""
            Me.txtCalm11.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm11_Click(sender As Object, e As EventArgs) Handles btnDelCalm11.Click
        Try
            If Me.dgvCalm11.RowCount > 0 Then
                Me.dgvCalm11.Rows.RemoveAt(Me.dgvCalm11.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm12_Click(sender As Object, e As EventArgs) Handles btnAddCalm12.Click
        Try
            Me.dgvCalm12.Rows.Add()
            Me.dgvCalm12.Rows(Me.dgvCalm12.RowCount - 1).Cells(0).Value = Me.txtCalm12.Text
            Me.txtCalm12.Text = ""
            Me.txtCalm12.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm12_Click(sender As Object, e As EventArgs) Handles btnDelCalm12.Click
        Try
            If Me.dgvCalm12.RowCount > 0 Then
                Me.dgvCalm12.Rows.RemoveAt(Me.dgvCalm12.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm13_Click(sender As Object, e As EventArgs) Handles btnAddCalm13.Click
        Try
            Me.dgvCalm13.Rows.Add()
            Me.dgvCalm13.Rows(Me.dgvCalm13.RowCount - 1).Cells(0).Value = Me.txtCalm13.Text
            Me.txtCalm13.Text = ""
            Me.txtCalm13.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm13_Click(sender As Object, e As EventArgs) Handles btnDelCalm13.Click
        Try
            If Me.dgvCalm13.RowCount > 0 Then
                Me.dgvCalm13.Rows.RemoveAt(Me.dgvCalm13.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm14_Click(sender As Object, e As EventArgs) Handles btnAddCalm14.Click
        Try
            Me.dgvCalm14.Rows.Add()
            Me.dgvCalm14.Rows(Me.dgvCalm14.RowCount - 1).Cells(0).Value = Me.txtCalm14.Text
            Me.txtCalm14.Text = ""
            Me.txtCalm14.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm14_Click(sender As Object, e As EventArgs) Handles btnDelCalm14.Click
        Try
            If Me.dgvCalm14.RowCount > 0 Then
                Me.dgvCalm14.Rows.RemoveAt(Me.dgvCalm14.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm15_Click(sender As Object, e As EventArgs) Handles btnAddCalm15.Click
        Try
            Me.dgvCalm15.Rows.Add()
            Me.dgvCalm15.Rows(Me.dgvCalm15.RowCount - 1).Cells(0).Value = Me.txtCalm15.Text
            Me.txtCalm15.Text = ""
            Me.txtCalm15.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm15_Click(sender As Object, e As EventArgs) Handles btnDelCalm15.Click
        Try
            If Me.dgvCalm15.RowCount > 0 Then
                Me.dgvCalm15.Rows.RemoveAt(Me.dgvCalm15.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm16_Click(sender As Object, e As EventArgs) Handles btnAddCalm16.Click
        Try
            Me.dgvCalm16.Rows.Add()
            Me.dgvCalm16.Rows(Me.dgvCalm16.RowCount - 1).Cells(0).Value = Me.txtCalm16.Text
            Me.txtCalm16.Text = ""
            Me.txtCalm16.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm16_Click(sender As Object, e As EventArgs) Handles btnDelCalm16.Click
        Try
            If Me.dgvCalm16.RowCount > 0 Then
                Me.dgvCalm16.Rows.RemoveAt(Me.dgvCalm16.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm17_Click(sender As Object, e As EventArgs) Handles btnAddCalm17.Click
        Try
            Me.dgvCalm17.Rows.Add()
            Me.dgvCalm17.Rows(Me.dgvCalm17.RowCount - 1).Cells(0).Value = Me.txtCalm17.Text
            Me.txtCalm17.Text = ""
            Me.txtCalm17.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm17_Click(sender As Object, e As EventArgs) Handles btnDelCalm17.Click
        Try
            If Me.dgvCalm17.RowCount > 0 Then
                Me.dgvCalm17.Rows.RemoveAt(Me.dgvCalm17.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm18_Click(sender As Object, e As EventArgs) Handles btnAddCalm18.Click
        Try
            If Me.txtCalm18CharName.TextLength = 0 Then
                MsgBox("このセリフは対象のキャラを指定する必要があります。")
                Exit Sub
            End If
            Me.dgvCalm18.Rows.Add()
            Me.dgvCalm18.Rows(Me.dgvCalm18.RowCount - 1).Cells(0).Value = Me.txtCalm18CharName.Text
            Me.dgvCalm18.Rows(Me.dgvCalm18.RowCount - 1).Cells(1).Value = Me.txtCalm18.Text
            Me.txtCalm18.Text = ""
            Me.txtCalm18.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm18_Click(sender As Object, e As EventArgs) Handles btnDelCalm18.Click
        Try
            If Me.dgvCalm18.RowCount > 0 Then
                Me.dgvCalm18.Rows.RemoveAt(Me.dgvCalm18.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm19_Click(sender As Object, e As EventArgs) Handles btnAddCalm19.Click
        Try
            Me.dgvCalm19.Rows.Add()
            Me.dgvCalm19.Rows(Me.dgvCalm19.RowCount - 1).Cells(0).Value = Me.txtCalm19.Text
            Me.txtCalm19.Text = ""
            Me.txtCalm19.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm19_Click(sender As Object, e As EventArgs) Handles btnDelCalm19.Click
        Try
            If Me.dgvCalm19.RowCount > 0 Then
                Me.dgvCalm19.Rows.RemoveAt(Me.dgvCalm19.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCalm20_Click(sender As Object, e As EventArgs) Handles btnAddCalm20.Click
        Try
            Me.dgvCalm20.Rows.Add()
            Me.dgvCalm20.Rows(Me.dgvCalm20.RowCount - 1).Cells(0).Value = Me.txtCalm20.Text
            Me.txtCalm20.Text = ""
            Me.txtCalm20.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelCalm20_Click(sender As Object, e As EventArgs) Handles btnDelCalm20.Click
        Try
            If Me.dgvCalm20.RowCount > 0 Then
                Me.dgvCalm20.Rows.RemoveAt(Me.dgvCalm20.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtCalm1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm1.Rows.Add()
                Me.dgvCalm1.Rows(Me.dgvCalm1.RowCount - 1).Cells(0).Value = Me.txtCalm1.Text
                Me.txtCalm1.Text = ""
                Me.txtCalm1.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm2.Rows.Add()
                Me.dgvCalm2.Rows(Me.dgvCalm2.RowCount - 1).Cells(0).Value = Me.txtCalm2.Text
                Me.txtCalm2.Text = ""
                Me.txtCalm2.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm3.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm3.Rows.Add()
                Me.dgvCalm3.Rows(Me.dgvCalm3.RowCount - 1).Cells(0).Value = Me.txtCalm3.Text
                Me.txtCalm3.Text = ""
                Me.txtCalm3.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm4.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm4.Rows.Add()
                Me.dgvCalm4.Rows(Me.dgvCalm4.RowCount - 1).Cells(0).Value = Me.txtCalm4.Text
                Me.txtCalm4.Text = ""
                Me.txtCalm4.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm5.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm5.Rows.Add()
                Me.dgvCalm5.Rows(Me.dgvCalm5.RowCount - 1).Cells(0).Value = Me.txtCalm5.Text
                Me.txtCalm5.Text = ""
                Me.txtCalm5.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm6_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm6.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm6.Rows.Add()
                Me.dgvCalm6.Rows(Me.dgvCalm6.RowCount - 1).Cells(0).Value = Me.txtCalm6.Text
                Me.txtCalm6.Text = ""
                Me.txtCalm6.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm7_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm7.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm7.Rows.Add()
                Me.dgvCalm7.Rows(Me.dgvCalm7.RowCount - 1).Cells(0).Value = Me.txtCalm7.Text
                Me.txtCalm7.Text = ""
                Me.txtCalm7.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm8_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm8.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm8.Rows.Add()
                Me.dgvCalm8.Rows(Me.dgvCalm8.RowCount - 1).Cells(0).Value = Me.txtCalm8.Text
                Me.txtCalm8.Text = ""
                Me.txtCalm8.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm9_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm9.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm9.Rows.Add()
                Me.dgvCalm9.Rows(Me.dgvCalm9.RowCount - 1).Cells(0).Value = Me.txtCalm9.Text
                Me.txtCalm9.Text = ""
                Me.txtCalm9.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm10_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm10.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm10.Rows.Add()
                Me.dgvCalm10.Rows(Me.dgvCalm10.RowCount - 1).Cells(0).Value = Me.txtCalm10.Text
                Me.txtCalm10.Text = ""
                Me.txtCalm10.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm11_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm11.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm11.Rows.Add()
                Me.dgvCalm11.Rows(Me.dgvCalm11.RowCount - 1).Cells(0).Value = Me.txtCalm11.Text
                Me.txtCalm11.Text = ""
                Me.txtCalm11.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm12_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm12.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm12.Rows.Add()
                Me.dgvCalm12.Rows(Me.dgvCalm12.RowCount - 1).Cells(0).Value = Me.txtCalm12.Text
                Me.txtCalm12.Text = ""
                Me.txtCalm12.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm13_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm13.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm13.Rows.Add()
                Me.dgvCalm13.Rows(Me.dgvCalm13.RowCount - 1).Cells(0).Value = Me.txtCalm13.Text
                Me.txtCalm13.Text = ""
                Me.txtCalm13.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm14_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm14.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm14.Rows.Add()
                Me.dgvCalm14.Rows(Me.dgvCalm14.RowCount - 1).Cells(0).Value = Me.txtCalm14.Text
                Me.txtCalm14.Text = ""
                Me.txtCalm14.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm15_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm15.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm15.Rows.Add()
                Me.dgvCalm15.Rows(Me.dgvCalm15.RowCount - 1).Cells(0).Value = Me.txtCalm15.Text
                Me.txtCalm15.Text = ""
                Me.txtCalm15.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm16_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm16.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm16.Rows.Add()
                Me.dgvCalm16.Rows(Me.dgvCalm16.RowCount - 1).Cells(0).Value = Me.txtCalm16.Text
                Me.txtCalm16.Text = ""
                Me.txtCalm16.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm17_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm17.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm17.Rows.Add()
                Me.dgvCalm17.Rows(Me.dgvCalm17.RowCount - 1).Cells(0).Value = Me.txtCalm17.Text
                Me.txtCalm17.Text = ""
                Me.txtCalm17.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm18_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm18.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm18.Rows.Add()
                Me.dgvCalm18.Rows(Me.dgvCalm18.RowCount - 1).Cells(0).Value = Me.txtCalm18.Text
                Me.txtCalm18.Text = ""
                Me.txtCalm18.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm19_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm19.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm19.Rows.Add()
                Me.dgvCalm19.Rows(Me.dgvCalm19.RowCount - 1).Cells(0).Value = Me.txtCalm19.Text
                Me.txtCalm19.Text = ""
                Me.txtCalm19.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtCalm20_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCalm20.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvCalm20.Rows.Add()
                Me.dgvCalm20.Rows(Me.dgvCalm20.RowCount - 1).Cells(0).Value = Me.txtCalm20.Text
                Me.txtCalm20.Text = ""
                Me.txtCalm20.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "スキル使用時イベントメソッド"
    Private Sub btnAddSkill1_Click(sender As Object, e As EventArgs) Handles btnAddSkill1.Click
        Try
            Me.dgvSkill1.Rows.Add()
            Me.dgvSkill1.Rows(Me.dgvSkill1.RowCount - 1).Cells(0).Value = Me.txtSkill1.Text
            Me.txtSkill1.Text = ""
            Me.txtSkill1.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnAddskill2_Click(sender As Object, e As EventArgs) Handles btnAddSkill2.Click
        Try
            Me.dgvSkill2.Rows.Add()
            Me.dgvSkill2.Rows(Me.dgvSkill2.RowCount - 1).Cells(0).Value = Me.txtSkill2.Text
            Me.txtSkill2.Text = ""
            Me.txtSkill2.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnAddskill3_Click(sender As Object, e As EventArgs) Handles btnAddSkill3.Click
        Try
            Me.dgvSkill3.Rows.Add()
            Me.dgvSkill3.Rows(Me.dgvSkill3.RowCount - 1).Cells(0).Value = Me.txtSkill3.Text
            Me.txtSkill3.Text = ""
            Me.txtSkill3.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnAddskill4_Click(sender As Object, e As EventArgs) Handles btnAddSkill4.Click
        Try
            Me.dgvSkill4.Rows.Add()
            Me.dgvSkill4.Rows(Me.dgvSkill4.RowCount - 1).Cells(0).Value = Me.txtSkill4.Text
            Me.txtSkill4.Text = ""
            Me.txtSkill4.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnAddskill5_Click(sender As Object, e As EventArgs) Handles btnAddSkill5.Click
        Try
            Me.dgvSkill5.Rows.Add()
            Me.dgvSkill5.Rows(Me.dgvSkill5.RowCount - 1).Cells(0).Value = Me.txtSkill5.Text
            Me.txtSkill5.Text = ""
            Me.txtSkill5.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnAddskill6_Click(sender As Object, e As EventArgs) Handles btnAddSkill6.Click
        Try
            Me.dgvSkill6.Rows.Add()
            Me.dgvSkill6.Rows(Me.dgvSkill6.RowCount - 1).Cells(0).Value = Me.txtSkill6.Text
            Me.txtSkill6.Text = ""
            Me.txtSkill6.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnAddskill7_Click(sender As Object, e As EventArgs) Handles btnAddSkill7.Click
        Try
            Me.dgvSkill7.Rows.Add()
            Me.dgvSkill7.Rows(Me.dgvSkill7.RowCount - 1).Cells(0).Value = Me.txtSkill7.Text
            Me.txtSkill7.Text = ""
            Me.txtSkill7.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnAddskill8_Click(sender As Object, e As EventArgs) Handles btnAddSkill8.Click
        Try
            Me.dgvSkill8.Rows.Add()
            Me.dgvSkill8.Rows(Me.dgvSkill8.RowCount - 1).Cells(0).Value = Me.cmbSkill8.SelectedValue
            Me.dgvSkill8.Rows(Me.dgvSkill8.RowCount - 1).Cells(1).Value = Me.cmbSkill8.Text
            Me.dgvSkill8.Rows(Me.dgvSkill8.RowCount - 1).Cells(2).Value = Me.txtSkill8.Text
            Me.txtSkill8.Text = ""
            Me.txtSkill8.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnAddskill9_Click(sender As Object, e As EventArgs) Handles btnAddSkill9.Click
        Try
            Me.dgvSkill9.Rows.Add()
            Me.dgvSkill9.Rows(Me.dgvSkill9.RowCount - 1).Cells(0).Value = Me.txtSkill9.Text
            Me.txtSkill9.Text = ""
            Me.txtSkill9.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnAddskill10_Click(sender As Object, e As EventArgs) Handles btnAddSkill10.Click
        Try
            Me.dgvSkill10.Rows.Add()
            Me.dgvSkill10.Rows(Me.dgvSkill10.RowCount - 1).Cells(0).Value = Me.txtSkill10.Text
            Me.txtSkill10.Text = ""
            Me.txtSkill10.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnAddskill11_Click(sender As Object, e As EventArgs) Handles btnAddSkill11.Click
        Try
            Me.dgvSkill11.Rows.Add()
            Me.dgvSkill11.Rows(Me.dgvSkill11.RowCount - 1).Cells(0).Value = Me.txtSkill11.Text
            Me.txtSkill11.Text = ""
            Me.txtSkill11.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnAddskill12_Click(sender As Object, e As EventArgs) Handles btnAddSkill12.Click
        Try
            Me.dgvSkill12.Rows.Add()
            Me.dgvSkill12.Rows(Me.dgvSkill12.RowCount - 1).Cells(0).Value = Me.txtSkill12.Text
            Me.txtSkill12.Text = ""
            Me.txtSkill12.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelSkill1_Click(sender As Object, e As EventArgs) Handles btnDelSkill1.Click
        Try
            If Me.dgvSkill1.RowCount > 0 Then
                Me.dgvSkill1.Rows.RemoveAt(Me.dgvSkill1.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelskill2_Click(sender As Object, e As EventArgs) Handles btnDelSkill2.Click
        Try
            If Me.dgvSkill2.RowCount > 0 Then
                Me.dgvSkill2.Rows.RemoveAt(Me.dgvSkill2.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelskill3_Click(sender As Object, e As EventArgs) Handles btnDelSkill3.Click
        Try
            If Me.dgvSkill3.RowCount > 0 Then
                Me.dgvSkill3.Rows.RemoveAt(Me.dgvSkill3.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelskill4_Click(sender As Object, e As EventArgs) Handles btnDelSkill4.Click
        Try
            If Me.dgvSkill4.RowCount > 0 Then
                Me.dgvSkill4.Rows.RemoveAt(Me.dgvSkill4.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelskill5_Click(sender As Object, e As EventArgs) Handles btnDelSkill5.Click
        Try
            If Me.dgvSkill5.RowCount > 0 Then
                Me.dgvSkill5.Rows.RemoveAt(Me.dgvSkill5.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelskill6_Click(sender As Object, e As EventArgs) Handles btnDelSkill6.Click
        Try
            If Me.dgvSkill6.RowCount > 0 Then
                Me.dgvSkill6.Rows.RemoveAt(Me.dgvSkill6.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelskill7_Click(sender As Object, e As EventArgs) Handles btnDelSkill7.Click
        Try
            If Me.dgvSkill7.RowCount > 0 Then
                Me.dgvSkill7.Rows.RemoveAt(Me.dgvSkill7.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelskill8_Click(sender As Object, e As EventArgs) Handles btnDelSkill8.Click
        Try
            If Me.dgvSkill8.RowCount > 0 Then
                Me.dgvSkill8.Rows.RemoveAt(Me.dgvSkill8.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelskill9_Click(sender As Object, e As EventArgs) Handles btnDelSkill9.Click
        Try
            If Me.dgvSkill9.RowCount > 0 Then
                Me.dgvSkill9.Rows.RemoveAt(Me.dgvSkill9.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelskill10_Click(sender As Object, e As EventArgs) Handles btnDelSkill10.Click
        Try
            If Me.dgvSkill10.RowCount > 0 Then
                Me.dgvSkill10.Rows.RemoveAt(Me.dgvSkill10.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelskill11_Click(sender As Object, e As EventArgs) Handles btnDelSkill11.Click
        Try
            If Me.dgvSkill11.RowCount > 0 Then
                Me.dgvSkill11.Rows.RemoveAt(Me.dgvSkill11.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnDelskill12_Click(sender As Object, e As EventArgs) Handles btnDelSkill12.Click
        Try
            If Me.dgvSkill12.RowCount > 0 Then
                Me.dgvSkill12.Rows.RemoveAt(Me.dgvSkill12.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtSkill1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSkill1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvSkill1.Rows.Add()
                Me.dgvSkill1.Rows(Me.dgvSkill1.RowCount - 1).Cells(0).Value = Me.txtSkill1.Text
                Me.txtSkill1.Text = ""
                Me.txtSkill1.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtskill2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSkill2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvSkill2.Rows.Add()
                Me.dgvSkill2.Rows(Me.dgvSkill2.RowCount - 1).Cells(0).Value = Me.txtSkill2.Text
                Me.txtSkill2.Text = ""
                Me.txtSkill2.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtskill3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSkill3.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvSkill3.Rows.Add()
                Me.dgvSkill3.Rows(Me.dgvSkill3.RowCount - 1).Cells(0).Value = Me.txtSkill3.Text
                Me.txtSkill3.Text = ""
                Me.txtSkill3.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtskill4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSkill4.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvSkill4.Rows.Add()
                Me.dgvSkill4.Rows(Me.dgvSkill4.RowCount - 1).Cells(0).Value = Me.txtSkill4.Text
                Me.txtSkill4.Text = ""
                Me.txtSkill4.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtskill5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSkill5.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvSkill5.Rows.Add()
                Me.dgvSkill5.Rows(Me.dgvSkill5.RowCount - 1).Cells(0).Value = Me.txtSkill5.Text
                Me.txtSkill5.Text = ""
                Me.txtSkill5.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtskill6_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSkill6.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvSkill6.Rows.Add()
                Me.dgvSkill6.Rows(Me.dgvSkill6.RowCount - 1).Cells(0).Value = Me.txtSkill6.Text
                Me.txtSkill6.Text = ""
                Me.txtSkill6.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtskill7_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSkill7.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvSkill7.Rows.Add()
                Me.dgvSkill7.Rows(Me.dgvSkill7.RowCount - 1).Cells(0).Value = Me.txtSkill7.Text
                Me.txtSkill7.Text = ""
                Me.txtSkill7.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtskill8_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSkill8.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvSkill8.Rows.Add()
                Me.dgvSkill8.Rows(Me.dgvSkill8.RowCount - 1).Cells(0).Value = Me.txtSkill8.Text
                Me.txtSkill8.Text = ""
                Me.txtSkill8.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtskill9_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSkill9.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvSkill9.Rows.Add()
                Me.dgvSkill9.Rows(Me.dgvSkill9.RowCount - 1).Cells(0).Value = Me.txtSkill9.Text
                Me.txtSkill9.Text = ""
                Me.txtSkill9.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtskill10_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSkill10.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvSkill10.Rows.Add()
                Me.dgvSkill10.Rows(Me.dgvSkill10.RowCount - 1).Cells(0).Value = Me.txtSkill10.Text
                Me.txtSkill10.Text = ""
                Me.txtSkill10.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtskill11_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSkill11.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvSkill11.Rows.Add()
                Me.dgvSkill11.Rows(Me.dgvSkill11.RowCount - 1).Cells(0).Value = Me.txtSkill11.Text
                Me.txtSkill11.Text = ""
                Me.txtSkill11.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtskill12_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSkill12.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dgvSkill12.Rows.Add()
                Me.dgvSkill12.Rows(Me.dgvSkill12.RowCount - 1).Cells(0).Value = Me.txtSkill12.Text
                Me.txtSkill12.Text = ""
                Me.txtSkill12.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "メソッド"
    ''' <summary>
    ''' テキストデータを全てまとめる
    ''' </summary>
    ''' <remarks></remarks>
    Private Function CreateTextClassData() As TextClass
        Dim TextData As New TextClass

        TextData.Text_Calm = CreateTextCalmData()

        TextData.Text_UseSkill = CreateTextSkillData()

        Return TextData
    End Function

    ''' <summary>
    ''' 待機・戦闘状態関連のテキストデータをクラスにまとめる
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CreateTextCalmData() As Text_Calm
        Dim TextCalm As New Text_Calm

        If Me.dgvCalm1.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm1.RowCount - 1
                TextCalm.txtCalm.Add(Me.dgvCalm1.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm2.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm2.RowCount - 1
                TextCalm.txtWelcome.Add(Me.dgvCalm2.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm3.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm3.RowCount - 1
                TextCalm.txtakita.Add(Me.dgvCalm3.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm4.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm4.RowCount - 1
                TextCalm.txturusai.Add(Me.dgvCalm4.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm5.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm5.RowCount - 1
                TextCalm.txtthrowrock.Add(Me.dgvCalm5.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm6.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm6.RowCount - 1
                TextCalm.txtbravo.Add(Me.dgvCalm6.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm7.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm7.RowCount - 1
                TextCalm.txtnoru.Add(Me.dgvCalm7.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm8.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm8.RowCount - 1
                TextCalm.txtoriru.Add(Me.dgvCalm8.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm9.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm9.RowCount - 1
                TextCalm.txtparasite.Add(Me.dgvCalm9.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm10.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm10.RowCount - 1
                TextCalm.txtumare.Add(Me.dgvCalm10.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm11.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm11.RowCount - 1
                TextCalm.txttobidasi.Add(Me.dgvCalm11.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm12.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm12.RowCount - 1
                TextCalm.txttoketa.Add(Me.dgvCalm12.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm13.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm13.RowCount - 1
                TextCalm.txtkunren.Add(Me.dgvCalm13.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm14.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm14.RowCount - 1
                TextCalm.txtAggro.Add(Me.dgvCalm14.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm15.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm15.RowCount - 1
                TextCalm.txtDead.Add(Me.dgvCalm15.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm16.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm16.RowCount - 1
                TextCalm.txtKilled.Add(Me.dgvCalm16.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm17.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm17.RowCount - 1
                TextCalm.txthinsi.Add(Me.dgvCalm17.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm18.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm18.RowCount - 1
                TextCalm.txtallykilledName.Add(Me.dgvCalm18.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
                TextCalm.txtallykilled.Add(Me.dgvCalm18.Rows(i).Cells(1).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm19.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm19.RowCount - 1
                TextCalm.txtallykilleddefault.Add(Me.dgvCalm19.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvCalm20.RowCount > 0 Then
            For i As Integer = 0 To dgvCalm20.RowCount - 1
                TextCalm.txtnikorose.Add(Me.dgvCalm20.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If


        Return TextCalm
    End Function

    ''' <summary>
    ''' スキル使用関連のテキストデータをクラスにまとめる
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CreateTextSkillData() As Text_UseSkill
        Dim TextSkill As New Text_UseSkill

        If Me.dgvSkill1.RowCount > 0 Then
            For i As Integer = 0 To dgvSkill1.RowCount - 1
                TextSkill.txtsing.Add(Me.dgvSkill1.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvSkill2.RowCount > 0 Then
            For i As Integer = 0 To dgvSkill2.RowCount - 1
                TextSkill.txtlayhand.Add(Me.dgvSkill2.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvSkill3.RowCount > 0 Then
            For i As Integer = 0 To dgvSkill3.RowCount - 1
                TextSkill.txtabuse.Add(Me.dgvSkill3.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvSkill4.RowCount > 0 Then
            For i As Integer = 0 To dgvSkill4.RowCount - 1
                TextSkill.txtbatou.Add(Me.dgvSkill4.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvSkill5.RowCount > 0 Then
            For i As Integer = 0 To dgvSkill5.RowCount - 1
                TextSkill.txtswarm.Add(Me.dgvSkill5.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvSkill6.RowCount > 0 Then
            For i As Integer = 0 To dgvSkill6.RowCount - 1
                TextSkill.txtkisei.Add(Me.dgvSkill6.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvSkill7.RowCount > 0 Then
            For i As Integer = 0 To dgvSkill7.RowCount - 1
                TextSkill.txtuzimushi.Add(Me.dgvSkill7.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvSkill8.RowCount > 0 Then
            For i As Integer = 0 To dgvSkill8.RowCount - 1
                TextSkill.txtcastmagicName.Add(Me.dgvSkill8.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
                TextSkill.txtcastmagic.Add(Me.dgvSkill8.Rows(i).Cells(2).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvSkill9.RowCount > 0 Then
            For i As Integer = 0 To dgvSkill9.RowCount - 1
                TextSkill.txtcaststyle.Add(Me.dgvSkill9.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvSkill10.RowCount > 0 Then
            For i As Integer = 0 To dgvSkill10.RowCount - 1
                TextSkill.txtcaststyle2.Add(Me.dgvSkill10.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvSkill11.RowCount > 0 Then
            For i As Integer = 0 To dgvSkill11.RowCount - 1
                TextSkill.txtactbefore647.Add(Me.dgvSkill11.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If

        If Me.dgvSkill12.RowCount > 0 Then
            For i As Integer = 0 To dgvSkill12.RowCount - 1
                TextSkill.txtactafter647.Add(Me.dgvSkill12.Rows(i).Cells(0).Value.ToString()) '.Replace(""""c, """"""))
            Next
        End If


        Return TextSkill
    End Function

    ''' <summary>
    ''' 魔法一覧コンボボックスの内容をセットする
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetCmbSkill8()
        'データテーブル生成
        Dim data As New DataTable()
        data.Columns.Add("ID", GetType(String))
        data.Columns.Add("NAME", GetType(String))

        '行データ生成
        Dim dataRow As DataRow

        '魔法----------------------------------------------------------------------
        dataRow = data.NewRow()
        dataRow("ID") = "400"
        dataRow("NAME") = "軽傷治癒"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "401"
        dataRow("NAME") = "致命傷治癒"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "402"
        dataRow("NAME") = "エリスの癒し"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "403"
        dataRow("NAME") = "ジュアの癒し"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "404"
        dataRow("NAME") = "治癒の雨"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "405"
        dataRow("NAME") = "癒しの手"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "406"
        dataRow("NAME") = "清浄なる光"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "407"
        dataRow("NAME") = "全浄化"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "408"
        dataRow("NAME") = "テレポート"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "409"
        dataRow("NAME") = "テレポートアザー"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "410"
        dataRow("NAME") = "ショートテレポート"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "411"
        dataRow("NAME") = "鑑定"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "412"
        dataRow("NAME") = "解呪"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "413"
        dataRow("NAME") = "神託"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "414"
        dataRow("NAME") = "魔法の矢"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "415"
        dataRow("NAME") = "地獄の吐息"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "416"
        dataRow("NAME") = "麻痺の矢"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "417"
        dataRow("NAME") = "混沌の瞳"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "418"
        dataRow("NAME") = "暗黒の矢"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "419"
        dataRow("NAME") = "アイスボルト"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "420"
        dataRow("NAME") = "ファイアボルト"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "421"
        dataRow("NAME") = "ライトニングボルト"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "422"
        dataRow("NAME") = "暗黒の光線"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "423"
        dataRow("NAME") = "幻影の光線"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "424"
        dataRow("NAME") = "モンスター召喚"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "425"
        dataRow("NAME") = "野生召喚"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "426"
        dataRow("NAME") = "炎召喚"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "427"
        dataRow("NAME") = "駒召喚"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "428"
        dataRow("NAME") = "帰還"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "429"
        dataRow("NAME") = "魔法の地図"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "430"
        dataRow("NAME") = "物質感知"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "431"
        dataRow("NAME") = "アイスボール"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "432"
        dataRow("NAME") = "ファイアボール"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "433"
        dataRow("NAME") = "混沌の渦"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "434"
        dataRow("NAME") = "轟音の波動"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "435"
        dataRow("NAME") = "支配"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "436"
        dataRow("NAME") = "蜘蛛の巣"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "437"
        dataRow("NAME") = "闇の霧"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "438"
        dataRow("NAME") = "壁生成"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "439"
        dataRow("NAME") = "肉体復活"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "440"
        dataRow("NAME") = "精神復活"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "441"
        dataRow("NAME") = "願い"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "442"
        dataRow("NAME") = "聖なる盾"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "443"
        dataRow("NAME") = "沈黙の霧"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "444"
        dataRow("NAME") = "リジェネレーション"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "445"
        dataRow("NAME") = "元素保護"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "446"
        dataRow("NAME") = "加速"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "447"
        dataRow("NAME") = "鈍足"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "448"
        dataRow("NAME") = "英雄"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "449"
        dataRow("NAME") = "脆弱の霧"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "450"
        dataRow("NAME") = "元素の傷跡"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "451"
        dataRow("NAME") = "ホーリーヴェイル"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "452"
        dataRow("NAME") = "ナイトメア"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "453"
        dataRow("NAME") = "知者の加護"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "454"
        dataRow("NAME") = "自己の変容"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "455"
        dataRow("NAME") = "酸の海"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "456"
        dataRow("NAME") = "炎の壁"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "457"
        dataRow("NAME") = "ドア生成"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "458"
        dataRow("NAME") = "インコグニート"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "459"
        dataRow("NAME") = "魔力の集積"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "460"
        dataRow("NAME") = "魔力の嵐"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "461"
        dataRow("NAME") = "復活"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "462"
        dataRow("NAME") = "契約"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "463"
        dataRow("NAME") = "四次元ポケット"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "464"
        dataRow("NAME") = "魔術師の収穫"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "465"
        dataRow("NAME") = "メテオ"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "466"
        dataRow("NAME") = "グラビティ"
        data.Rows.Add(dataRow)

        Me.cmbSkill8.DataSource = data
        Me.cmbSkill8.DisplayMember = "NAME"
        Me.cmbSkill8.ValueMember = "ID"

    End Sub
#End Region


End Class