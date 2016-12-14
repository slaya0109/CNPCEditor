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

#End Region

#Region "メソッド"
    ''' <summary>
    ''' テキストデータを全てまとめる
    ''' </summary>
    ''' <remarks></remarks>
    Private Function CreateTextClassData() As TextClass
        Dim TextData As New TextClass

        TextData.Text_Calm = CreateTextCalmData()

        Return TextData
    End Function

    ''' <summary>
    ''' 待機・戦闘状態関連のテキストデータをまとめる
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
#End Region

  
End Class