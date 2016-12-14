Imports System.Text
Imports System.IO

Public Class MainForm

    Public SendTextData As TextClass

#Region "イベントメソッド"
    ''' <summary>
    ''' ロードイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '種族コンボボックスセット
            Me.SetCmbRace()
            '職業コンボボックスセット
            SetCmbClass()
            '0~100,1~100の数値コンボボックスセット
            SetNumValueCmbs()
            '属性耐性強度コンボボックスセット
            SetCmbRegistPower()
            '属性コンボボックスセット
            SetElementCmbs()
            '補正コンボボックスセット
            SetCmbBit()
            '関係性コンボボックスセット
            SetCmbRelation()
            '性別コンボボックスセット
            SetCmbSex()
            '生成品質コンボボックスセット
            SetCmbFixLv()
            '生成条件コンボボックスセット
            SetCmbSpawnType()
            '待機時AIコンボボックスセット
            SetCmbAiCalm()
            '行動系コンボボックスセット
            SetCmbAct()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 終了ボタンイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("終了しますか?", "確認", MessageBoxButtons.OKCancel) = System.Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' 素手格闘属性強度入力制御
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtMeleeElemPower_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeleeElemPower.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c OrElse "9"c < e.KeyChar) AndAlso _
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' 耐性行追加ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAddRegist_Click(sender As Object, e As EventArgs) Handles btnAddRegist.Click
        Try
            Me.dgvRegistElem.Rows.Add()
            Me.dgvRegistElem.Rows(Me.dgvRegistElem.RowCount - 1).Cells(0).Value = Me.cmbRegistElem.SelectedValue
            Me.dgvRegistElem.Rows(Me.dgvRegistElem.RowCount - 1).Cells(1).Value = Me.cmbRegistElem.Text
            Me.dgvRegistElem.Rows(Me.dgvRegistElem.RowCount - 1).Cells(2).Value = Me.cmbRegistElemPower.SelectedValue
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' 耐性行削除ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDelRegist_Click(sender As Object, e As EventArgs) Handles btnDelRegist.Click
        Try
            If Me.dgvRegistElem.RowCount > 0 Then
                Me.dgvRegistElem.Rows.RemoveAt(Me.dgvRegistElem.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' 補正行追加ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAddBit_Click(sender As Object, e As EventArgs) Handles btnAddBit.Click
        Try
            Me.dgvBit.Rows.Add()
            Me.dgvBit.Rows(Me.dgvBit.RowCount - 1).Cells(0).Value = Me.cmbBit.SelectedValue
            Me.dgvBit.Rows(Me.dgvBit.RowCount - 1).Cells(1).Value = Me.cmbBit.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' 補正行削除ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDelBit_Click(sender As Object, e As EventArgs) Handles btnDelBit.Click
        Try
            If Me.dgvBit.RowCount > 0 Then
                Me.dgvBit.Rows.RemoveAt(Me.dgvBit.CurrentRow.Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' txtファイル作成ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExcute_Click(sender As Object, e As EventArgs) Handles btnExcute.Click
        Try

            '入力チェック
            If CheckValues() = False Then
                Exit Sub
            End If

            If MessageBox.Show("テキストファイルを作成しますか?", "確認", MessageBoxButtons.OKCancel) = System.Windows.Forms.DialogResult.OK Then
                Dim saveDialog As New SaveFileDialog()
                saveDialog.FileName = "cnpc.txt"
                saveDialog.InitialDirectory = ""
                '[ファイルの種類]に表示される選択肢を指定する
                saveDialog.Filter = "txtファイル(*.txt)|*.txt"
                '[ファイルの種類]ではじめに選択されるものを指定する
                '2番目の「すべてのファイル」が選択されているようにする
                saveDialog.FilterIndex = 2
                'タイトルを設定する
                saveDialog.Title = "保存先のファイルを選択してください"
                'ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
                saveDialog.RestoreDirectory = True
                '既に存在するファイル名を指定したとき警告する
                'デフォルトでTrueなので指定する必要はない
                saveDialog.OverwritePrompt = True
                '存在しないパスが指定されたとき警告を表示する
                'デフォルトでTrueなので指定する必要はない
                saveDialog.CheckPathExists = True

                'ダイアログを表示する
                If saveDialog.ShowDialog() = DialogResult.OK Then
                    'OKボタンがクリックされたとき、選択されたファイル名に出力
                    Dim txtFile As StreamWriter
                    txtFile = New StreamWriter(saveDialog.FileName, False, System.Text.Encoding.Default)
                    txtFile.Write(Me.CreateStringData())
                    txtFile.Close()
                    MsgBox("txtファイルの出力に成功しました。", MsgBoxStyle.OkOnly, "出力完了")
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "メソッド"

    ''' <summary>
    ''' 種族選択コンボボックスの内容セット
    ''' 外部テキストなどを読み込みたくなかったのでベタ書きのクソコード
    ''' </summary>
    Private Sub SetCmbRace()
        'データテーブル生成
        Dim data As New DataTable()
        data.Columns.Add("ID", GetType(String))
        data.Columns.Add("NAME", GetType(String))

        '行データ生成
        Dim dataRow As DataRow

        '新規行生成
        dataRow = data.NewRow()
        dataRow("ID") = "kobolt"
        dataRow("NAME") = "コボルト"
        'データテーブルに追加
        data.Rows.Add(dataRow)

        dataRow = data.NewRow()
        dataRow("ID") = "minotaur"
        dataRow("NAME") = "ミノタウロス"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "fairy"
        dataRow("NAME") = "妖精"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "dwarf"
        dataRow("NAME") = "丘の民"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "rabbit"
        dataRow("NAME") = "ウサギ"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "snail"
        dataRow("NAME") = "かたつむり"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "bat"
        dataRow("NAME") = "コウモリ"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "ghost"
        dataRow("NAME") = "幽霊"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "wasp"
        dataRow("NAME") = "ワスプ"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "snake"
        dataRow("NAME") = "蛇"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "armor"
        dataRow("NAME") = "鎧"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "harpy"
        dataRow("NAME") = "ハーピー"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "spider"
        dataRow("NAME") = "蜘蛛"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "skeleton"
        dataRow("NAME") = "骸骨"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "roran"
        dataRow("NAME") = "ローラン"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "machinegod"
        dataRow("NAME") = "機械の神"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "chicken"
        dataRow("NAME") = "鶏"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "yeek"
        dataRow("NAME") = "イーク"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "god"
        dataRow("NAME") = "神"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "orc"
        dataRow("NAME") = "オーク"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "yerles"
        dataRow("NAME") = "イェルス"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "asura"
        dataRow("NAME") = "阿修羅"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "juere"
        dataRow("NAME") = "ジューア"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "sheep"
        dataRow("NAME") = "羊"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "mandrake"
        dataRow("NAME") = "マンドレイク"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "ent"
        dataRow("NAME") = "エント"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "spirit"
        dataRow("NAME") = "精霊"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "giant"
        dataRow("NAME") = "巨人"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "drake"
        dataRow("NAME") = "ドレイク"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "medusa"
        dataRow("NAME") = "メデューサ"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "dragon"
        dataRow("NAME") = "ドラゴン"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "golem"
        dataRow("NAME") = "ゴーレム"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "piece"
        dataRow("NAME") = "駒"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "rat"
        dataRow("NAME") = "ねずみ"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "undeadgod"
        dataRow("NAME") = "死霊の神"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "stalker"
        dataRow("NAME") = "ストーカー"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "yith"
        dataRow("NAME") = "イス"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "quickling"
        dataRow("NAME") = "クイックリング"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "troll"
        dataRow("NAME") = "トロール"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "norland"
        dataRow("NAME") = "ノーランド"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "slime"
        dataRow("NAME") = "スライム"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "zombie"
        dataRow("NAME") = "ゾンビ"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "frog"
        dataRow("NAME") = "蛙"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "beetle"
        dataRow("NAME") = "昆虫"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "lich"
        dataRow("NAME") = "リッチ"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "eye"
        dataRow("NAME") = "目"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "imp"
        dataRow("NAME") = "インプ"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "goblin"
        dataRow("NAME") = "ゴブリン"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "cupid"
        dataRow("NAME") = "キューピット"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "dinosaur"
        dataRow("NAME") = "恐竜"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "rock"
        dataRow("NAME") = "岩"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "cat"
        dataRow("NAME") = "猫"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "shell"
        dataRow("NAME") = "やどかり"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "machine"
        dataRow("NAME") = "機械"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "catsister"
        dataRow("NAME") = "猫妹"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "servant"
        dataRow("NAME") = "神の化身"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "metal"
        dataRow("NAME") = "メタル"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "lizardman"
        dataRow("NAME") = "リザードマン"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "eulderna"
        dataRow("NAME") = "エウダーナ"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "wolf"
        dataRow("NAME") = "狼"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "elea"
        dataRow("NAME") = "エレア"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "centipede"
        dataRow("NAME") = "ムカデ"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "mushroom"
        dataRow("NAME") = "きのこ"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "hound"
        dataRow("NAME") = "猟犬"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "wyvern"
        dataRow("NAME") = "ワイバーン"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "hand"
        dataRow("NAME") = "手"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "bear"
        dataRow("NAME") = "熊"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "phantom"
        dataRow("NAME") = "ファントム"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "cerberus"
        dataRow("NAME") = "ケルベロス"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "crab"
        dataRow("NAME") = "蟹"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "dog"
        dataRow("NAME") = "犬"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "catgod"
        dataRow("NAME") = "猫の神"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "wisp"
        dataRow("NAME") = "ウィスプ"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "mutant"
        dataRow("NAME") = "カオスシェイプ"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "horse"
        dataRow("NAME") = "馬"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "bike"
        dataRow("NAME") = "バイク"
        data.Rows.Add(dataRow)

        Me.cmbRace.DataSource = data
        Me.cmbRace.ValueMember = "ID"
        Me.cmbRace.DisplayMember = "NAME"
    End Sub

    ''' <summary>
    ''' 職業選択コンボボックスの内容セット
    ''' 外部テキストなどを読み込みたくなかったのでベタ書きのクソコード
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetCmbClass()
        'データテーブル生成
        Dim data As New DataTable()
        data.Columns.Add("ID", GetType(String))
        data.Columns.Add("NAME", GetType(String))

        '行データ生成
        Dim dataRow As DataRow

        '新規行生成
        dataRow = data.NewRow()
        dataRow("ID") = "warrior"
        dataRow("NAME") = "戦士"
        'データテーブルに追加
        data.Rows.Add(dataRow)

        dataRow = data.NewRow()
        dataRow("ID") = "thief"
        dataRow("NAME") = "遺跡荒らし"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "wizard"
        dataRow("NAME") = "魔法使い"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "farmer"
        dataRow("NAME") = "農民"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "predator"
        dataRow("NAME") = "プレデター"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "archer"
        dataRow("NAME") = "狩人"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "warmage"
        dataRow("NAME") = "魔法戦士"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "pianist"
        dataRow("NAME") = "ピアニスト"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "gunner"
        dataRow("NAME") = "機工兵"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "priest"
        dataRow("NAME") = "神官"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "claymore"
        dataRow("NAME") = "クレイモア"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "tourist"
        dataRow("NAME") = "観光客"
        data.Rows.Add(dataRow)

        Me.cmbClass.DataSource = data
        Me.cmbClass.DisplayMember = "NAME"
        Me.cmbClass.ValueMember = "ID"
    End Sub

    ''' <summary>
    ''' 1~100、もしくは0~100の値が必要なコンボボックスに内容をセットする
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetNumValueCmbs()
        '初期レベル
        Me.cmbLevel.DataSource = CreateDataTable_Num1To100Value()
        Me.cmbLevel.DisplayMember = "NAME"
        Me.cmbLevel.ValueMember = "ID"

        '生成頻度
        Me.cmbRare.DataSource = CreateDataTable_Num0To100Value()
        Me.cmbRare.DisplayMember = "NAME"
        Me.cmbRare.ValueMember = "ID"

        '移動確率
        Me.cmbAiMove.DataSource = CreateDataTable_Num0To100Value()
        Me.cmbAiMove.DisplayMember = "NAME"
        Me.cmbAiMove.ValueMember = "ID"

        '適正距離
        Me.cmbAiDist.DataSource = CreateDataTable_Num1To100Value()
        Me.cmbAiDist.DisplayMember = "NAME"
        Me.cmbAiDist.ValueMember = "ID"

        '特殊行動確率
        Me.cmbAiActSubFreq.DataSource = CreateDataTable_Num0To100Value()
        Me.cmbAiActSubFreq.DisplayMember = "NAME"
        Me.cmbAiActSubFreq.ValueMember = "ID"


    End Sub

    ''' <summary>
    ''' 属性耐性強度コンボボックスの内容セット
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetCmbRegistPower()
        'データテーブル生成
        Dim data As New DataTable()
        data.Columns.Add("ID", GetType(String))
        data.Columns.Add("NAME", GetType(String))

        '行データ生成
        Dim dataRow As DataRow

        For i As Integer = -10 To 10
            '新規行生成
            dataRow = data.NewRow()
            dataRow("ID") = i.ToString()
            dataRow("NAME") = i.ToString()
            'データテーブルに追加
            data.Rows.Add(dataRow)
        Next

        Me.cmbRegistElemPower.DataSource = data
        Me.cmbRegistElemPower.DisplayMember = "NAME"
        Me.cmbRegistElemPower.ValueMember = "ID"
    End Sub

    ''' <summary>
    ''' 属性コンボボックスをセットする
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetElementCmbs()
        Me.cmbMeleeElem.DataSource = CreateElementList()
        Me.cmbMeleeElem.DisplayMember = "NAME"
        Me.cmbMeleeElem.ValueMember = "ID"

        Me.cmbRegistElem.DataSource = CreateElementList()
        Me.cmbRegistElem.DisplayMember = "NAME"
        Me.cmbRegistElem.ValueMember = "ID"
    End Sub

    ''' <summary>
    ''' 補正コンボボックスをセットする
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetCmbBit()
        'データテーブル生成
        Dim data As New DataTable()
        data.Columns.Add("ID", GetType(String))
        data.Columns.Add("NAME", GetType(String))

        '行データ生成
        Dim dataRow As DataRow

        '新規行生成
        dataRow = data.NewRow()
        dataRow("ID") = "5"
        dataRow("NAME") = "浮遊"
        'データテーブルに追加
        data.Rows.Add(dataRow)

        dataRow = data.NewRow()
        dataRow("ID") = "6"
        dataRow("NAME") = "透明"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "7"
        dataRow("NAME") = "透明な物を見る"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "8"
        dataRow("NAME") = "混乱を無効"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "9"
        dataRow("NAME") = "盲目を無効"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "10"
        dataRow("NAME") = "恐怖とそれによる逃亡を無効"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "11"
        dataRow("NAME") = "睡眠を無効"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "12"
        dataRow("NAME") = "麻痺を無効"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "13"
        dataRow("NAME") = "毒を無効"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "14"
        dataRow("NAME") = "腐った物を難なく消化する"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "15"
        dataRow("NAME") = "アイテムを盗まれなくする"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "16"
        dataRow("NAME") = "変装中"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "17"
        dataRow("NAME") = "死亡時に必ず所持金を落とす"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "18"
        dataRow("NAME") = "自爆生物"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "19"
        dataRow("NAME") = "死の宣告持ち"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "20"
        dataRow("NAME") = "連続魔法持ち"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "21"
        dataRow("NAME") = "レイハンド持ち"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "22"
        dataRow("NAME") = "適正騎乗生物"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "23"
        dataRow("NAME") = "分裂生物"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "24"
        dataRow("NAME") = "自動発動型エンチャント装備中"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "25"
        dataRow("NAME") = "非適正騎乗生物(非力すぎる)"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "26"
        dataRow("NAME") = "魔法以外の属性ダメージに強い"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "27"
        dataRow("NAME") = "分裂生物(キューブ)"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "28"
        dataRow("NAME") = "金属生物(ダメージ1/10)"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "29"
        dataRow("NAME") = "出血を抑える"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "30"
        dataRow("NAME") = "バッシュの発生率アップ"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "31"
        dataRow("NAME") = "地雷無効"
        data.Rows.Add(dataRow)

        Me.cmbBit.DataSource = data
        Me.cmbBit.DisplayMember = "NAME"
        Me.cmbBit.ValueMember = "ID"

    End Sub

    ''' <summary>
    ''' 関係性コンボボックスセット
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetCmbRelation()
        'データテーブル生成
        Dim data As New DataTable()
        data.Columns.Add("ID", GetType(String))
        data.Columns.Add("NAME", GetType(String))

        '行データ生成
        Dim dataRow As DataRow

        '新規行生成
        dataRow = data.NewRow()
        dataRow("ID") = "-3"
        dataRow("NAME") = "敵対"
        'データテーブルに追加
        data.Rows.Add(dataRow)

        dataRow = data.NewRow()
        dataRow("ID") = "-2"
        dataRow("NAME") = "敵対一歩寸前"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "-1"
        dataRow("NAME") = "無関心"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "0"
        dataRow("NAME") = "中立"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "10"
        dataRow("NAME") = "友好"
        data.Rows.Add(dataRow)

        Me.cmbRelation.DataSource = data
        Me.cmbRelation.DisplayMember = "NAME"
        Me.cmbRelation.ValueMember = "ID"
    End Sub

    ''' <summary>
    ''' 性別コンボボックスセット
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetCmbSex()
        'データテーブル生成
        Dim data As New DataTable()
        data.Columns.Add("ID", GetType(String))
        data.Columns.Add("NAME", GetType(String))

        '行データ生成
        Dim dataRow As DataRow

        '新規行生成
        dataRow = data.NewRow()
        dataRow("ID") = "-1"
        dataRow("NAME") = "ランダム"
        'データテーブルに追加
        data.Rows.Add(dataRow)

        dataRow = data.NewRow()
        dataRow("ID") = "0"
        dataRow("NAME") = "男"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "1"
        dataRow("NAME") = "女"
        data.Rows.Add(dataRow)

        Me.cmbSex.DataSource = data
        Me.cmbSex.DisplayMember = "NAME"
        Me.cmbSex.ValueMember = "ID"
    End Sub

    ''' <summary>
    ''' 生成品質コンボボックスセット
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetCmbFixLv()
        'データテーブル生成
        Dim data As New DataTable()
        data.Columns.Add("ID", GetType(String))
        data.Columns.Add("NAME", GetType(String))

        '行データ生成
        Dim dataRow As DataRow

        '新規行生成
        dataRow = data.NewRow()
        dataRow("ID") = "0"
        dataRow("NAME") = "ランダム"
        'データテーブルに追加
        data.Rows.Add(dataRow)

        dataRow = data.NewRow()
        dataRow("ID") = "1"
        dataRow("NAME") = "Bad(粗悪)"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "2"
        dataRow("NAME") = "Normal(良質)"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "3"
        dataRow("NAME") = "Good(高品質)"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "4"
        dataRow("NAME") = "Great(奇跡)"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "5"
        dataRow("NAME") = "Godly(神器)"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "6"
        dataRow("NAME") = "Unique(特別)"
        data.Rows.Add(dataRow)

        Me.cmbFixLv.DataSource = data
        Me.cmbFixLv.DisplayMember = "NAME"
        Me.cmbFixLv.ValueMember = "ID"
    End Sub

    ''' <summary>
    ''' 生成条件コンボボックスセット
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetCmbSpawnType()
        'データテーブル生成
        Dim data As New DataTable()
        data.Columns.Add("ID", GetType(String))
        data.Columns.Add("NAME", GetType(String))

        '行データ生成
        Dim dataRow As DataRow

        '新規行生成
        dataRow = data.NewRow()
        dataRow("ID") = "0"
        dataRow("NAME") = "通常"
        'データテーブルに追加
        data.Rows.Add(dataRow)

        dataRow = data.NewRow()
        dataRow("ID") = "1"
        dataRow("NAME") = "特殊"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "2"
        dataRow("NAME") = "通常(ユニーク)"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "3"
        dataRow("NAME") = "特殊(ユニーク)"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "4"
        dataRow("NAME") = "神々の休戦地、ルミエスト墓所"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "5"
        dataRow("NAME") = "街"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "6"
        dataRow("NAME") = "SFな街?"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "7"
        dataRow("NAME") = "店、博物館"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "8"
        dataRow("NAME") = "雪原?"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "9"
        dataRow("NAME") = "街(特殊)"
        data.Rows.Add(dataRow)

        Me.cmbSpawnType.DataSource = data
        Me.cmbSpawnType.DisplayMember = "NAME"
        Me.cmbSpawnType.ValueMember = "ID"
    End Sub

    ''' <summary>
    ''' 待機時AIコンボボックスセット
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetCmbAiCalm()
        'データテーブル生成
        Dim data As New DataTable()
        data.Columns.Add("ID", GetType(String))
        data.Columns.Add("NAME", GetType(String))

        '行データ生成
        Dim dataRow As DataRow

        '新規行生成
        dataRow = data.NewRow()
        dataRow("ID") = "1"
        dataRow("NAME") = "放浪"
        'データテーブルに追加
        data.Rows.Add(dataRow)

        dataRow = data.NewRow()
        dataRow("ID") = "2"
        dataRow("NAME") = "鈍感"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "3"
        dataRow("NAME") = "停止"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "4"
        dataRow("NAME") = "随行"
        data.Rows.Add(dataRow)

        Me.cmbAiCalm.DataSource = data
        Me.cmbAiCalm.DisplayMember = "NAME"
        Me.cmbAiCalm.ValueMember = "ID"
    End Sub

    ''' <summary>
    ''' 行動系のコンボボックスセット
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetCmbAct()
        '瀕死時行動
        Me.cmbAiHeal.DataSource = CreateActList()
        Me.cmbAiHeal.DisplayMember = "NAME"
        Me.cmbAiHeal.ValueMember = "ID"
        '基本行動1
        Me.cmbAiAct1.DataSource = CreateActList()
        Me.cmbAiAct1.DisplayMember = "NAME"
        Me.cmbAiAct1.ValueMember = "ID"
        '基本行動2
        Me.cmbAiAct2.DataSource = CreateActList()
        Me.cmbAiAct2.DisplayMember = "NAME"
        Me.cmbAiAct2.ValueMember = "ID"
        '基本行動3
        Me.cmbAiAct3.DataSource = CreateActList()
        Me.cmbAiAct3.DisplayMember = "NAME"
        Me.cmbAiAct3.ValueMember = "ID"
        '基本行動4
        Me.cmbAiAct4.DataSource = CreateActList()
        Me.cmbAiAct4.DisplayMember = "NAME"
        Me.cmbAiAct4.ValueMember = "ID"
        '基本行動5
        Me.cmbAiAct5.DataSource = CreateActList()
        Me.cmbAiAct5.DisplayMember = "NAME"
        Me.cmbAiAct5.ValueMember = "ID"
        '特殊行動1
        Me.cmbAiActSub1.DataSource = CreateActList()
        Me.cmbAiActSub1.DisplayMember = "NAME"
        Me.cmbAiActSub1.ValueMember = "ID"
        '特殊行動2
        Me.cmbAiActSub2.DataSource = CreateActList()
        Me.cmbAiActSub2.DisplayMember = "NAME"
        Me.cmbAiActSub2.ValueMember = "ID"
        '特殊行動3
        Me.cmbAiActSub3.DataSource = CreateActList()
        Me.cmbAiActSub3.DisplayMember = "NAME"
        Me.cmbAiActSub3.ValueMember = "ID"
        '特殊行動4
        Me.cmbAiActSub4.DataSource = CreateActList()
        Me.cmbAiActSub4.DisplayMember = "NAME"
        Me.cmbAiActSub4.ValueMember = "ID"
        '特殊行動5
        Me.cmbAiActSub5.DataSource = CreateActList()
        Me.cmbAiActSub5.DisplayMember = "NAME"
        Me.cmbAiActSub5.ValueMember = "ID"
    End Sub

    ''' <summary>
    ''' 属性一覧を返す
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CreateElementList() As DataTable
        'データテーブル生成
        Dim data As New DataTable()
        data.Columns.Add("ID", GetType(String))
        data.Columns.Add("NAME", GetType(String))

        '行データ生成
        Dim dataRow As DataRow

        '新規行生成
        dataRow = data.NewRow()
        dataRow("ID") = "50"
        dataRow("NAME") = "火炎"
        'データテーブルに追加
        data.Rows.Add(dataRow)

        dataRow = data.NewRow()
        dataRow("ID") = "51"
        dataRow("NAME") = "冷気"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "52"
        dataRow("NAME") = "電撃"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "53"
        dataRow("NAME") = "暗黒"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "54"
        dataRow("NAME") = "幻惑"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "55"
        dataRow("NAME") = "毒"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "56"
        dataRow("NAME") = "地獄"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "57"
        dataRow("NAME") = "音"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "58"
        dataRow("NAME") = "神経"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "59"
        dataRow("NAME") = "混沌"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "60"
        dataRow("NAME") = "魔法"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "61"
        dataRow("NAME") = "切り傷"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "62"
        dataRow("NAME") = "エーテル"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "63"
        dataRow("NAME") = "酸"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "64"
        dataRow("NAME") = "無属性"
        data.Rows.Add(dataRow)
        Return data
    End Function

    ''' <summary>
    ''' 1~100の値のリストを返す
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CreateDataTable_Num1To100Value() As DataTable
        'データテーブル生成
        Dim data As New DataTable()
        data.Columns.Add("ID", GetType(String))
        data.Columns.Add("NAME", GetType(String))

        '行データ生成
        Dim dataRow As DataRow

        For i As Integer = 1 To 100
            '新規行生成
            dataRow = data.NewRow()
            dataRow("ID") = i.ToString()
            dataRow("NAME") = i.ToString()
            'データテーブルに追加
            data.Rows.Add(dataRow)
        Next

        Return data
    End Function

    ''' <summary>
    ''' 0~100の値のリストを返す
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CreateDataTable_Num0To100Value() As DataTable
        'データテーブル生成
        Dim data As New DataTable()
        data.Columns.Add("ID", GetType(String))
        data.Columns.Add("NAME", GetType(String))

        '行データ生成
        Dim dataRow As DataRow

        For i As Integer = 0 To 100
            '新規行生成
            dataRow = data.NewRow()
            dataRow("ID") = i.ToString()
            dataRow("NAME") = i.ToString()
            'データテーブルに追加
            data.Rows.Add(dataRow)
        Next

        Return data
    End Function

    ''' <summary>
    ''' 行動一覧のリストを返す
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CreateActList() As DataTable
        'データテーブル生成
        Dim data As New DataTable()
        data.Columns.Add("ID", GetType(String))
        data.Columns.Add("NAME", GetType(String))

        '行データ生成
        Dim dataRow As DataRow

        '一般----------------------------------------------------------------------
        '新規行生成
        dataRow = data.NewRow()
        dataRow("ID") = "0"
        dataRow("NAME") = "何もしない"
        'データテーブルに追加
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "-1"
        dataRow("NAME") = "近接攻撃"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "-2"
        dataRow("NAME") = "遠隔攻撃"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "-3"
        dataRow("NAME") = "接近待ち"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "-4"
        dataRow("NAME") = "ランダムな方向に移動"
        data.Rows.Add(dataRow)

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
        '能力----------------------------------------------------------------------
        dataRow = data.NewRow()
        dataRow("ID") = "601"
        dataRow("NAME") = "吸血の牙"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "602"
        dataRow("NAME") = "炎のブレス"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "603"
        dataRow("NAME") = "冷気のブレス"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "604"
        dataRow("NAME") = "電撃のブレス"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "605"
        dataRow("NAME") = "暗黒のブレス"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "606"
        dataRow("NAME") = "混沌のブレス"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "607"
        dataRow("NAME") = "轟音のブレス"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "608"
        dataRow("NAME") = "地獄のブレス"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "609"
        dataRow("NAME") = "神経のブレス"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "610"
        dataRow("NAME") = "毒のブレス"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "611"
        dataRow("NAME") = "幻惑のブレス"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "612"
        dataRow("NAME") = "強力なブレス"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "613"
        dataRow("NAME") = "弱体化の手"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "614"
        dataRow("NAME") = "飢餓の手"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "615"
        dataRow("NAME") = "毒の手"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "616"
        dataRow("NAME") = "麻痺の手"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "617"
        dataRow("NAME") = "恐怖の手"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "618"
        dataRow("NAME") = "眠りの手"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "619"
        dataRow("NAME") = "接近"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "620"
        dataRow("NAME") = "異次元の手"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "621"
        dataRow("NAME") = "マナ回復"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "622"
        dataRow("NAME") = "神罰"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "623"
        dataRow("NAME") = "ジュアの祈り"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "624"
        dataRow("NAME") = "魔力の吸収"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "625"
        dataRow("NAME") = "ルルウィの憑依"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "626"
        dataRow("NAME") = "自己認識"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "627"
        dataRow("NAME") = "空間歪曲"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "628"
        dataRow("NAME") = "他者変容"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "629"
        dataRow("NAME") = "魔力の抽出"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "630"
        dataRow("NAME") = "魔力の充填"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "631"
        dataRow("NAME") = "スウォーム"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "632"
        dataRow("NAME") = "変容の眼差し"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "633"
        dataRow("NAME") = "エーテルの眼差し"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "634"
        dataRow("NAME") = "エーテルの海"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "635"
        dataRow("NAME") = "スリの指"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "636"
        dataRow("NAME") = "狂気の眼差し"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "637"
        dataRow("NAME") = "狂気治癒の雨"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "638"
        dataRow("NAME") = "朦朧の眼差し"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "639"
        dataRow("NAME") = "猫召喚"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "640"
        dataRow("NAME") = "イーク召喚"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "641"
        dataRow("NAME") = "駒召喚"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "642"
        dataRow("NAME") = "炎召喚"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "643"
        dataRow("NAME") = "妹召喚"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "644"
        dataRow("NAME") = "自爆"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "645"
        dataRow("NAME") = "呪いの言葉"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "646"
        dataRow("NAME") = "死の宣告"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "647"
        dataRow("NAME") = "ブースト"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "648"
        dataRow("NAME") = "罵倒"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "649"
        dataRow("NAME") = "遠距離打撃(射程5)"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "650"
        dataRow("NAME") = "遠距離打撃(射程7)"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "651"
        dataRow("NAME") = "喰い漁り"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "652"
        dataRow("NAME") = "マナの眼差し"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "653"
        dataRow("NAME") = "退却"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "654"
        dataRow("NAME") = "寄生"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "655"
        dataRow("NAME") = "グレネード"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "656"
        dataRow("NAME") = "鼓舞"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "657"
        dataRow("NAME") = "うみみやぁ！"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "658"
        dataRow("NAME") = "首狩り"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "659"
        dataRow("NAME") = "地雷投下"
        data.Rows.Add(dataRow)
        'その他----------------------------------------------------------------------
        dataRow = data.NewRow()
        dataRow("ID") = "-9996"
        dataRow("NAME") = "塩投擲"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "-9997"
        dataRow("NAME") = "ポーション投擲・大"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "-9998"
        dataRow("NAME") = "ポーション投擲・中"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "-9999"
        dataRow("NAME") = "ポーション投擲・小"
        data.Rows.Add(dataRow)
        dataRow = data.NewRow()
        dataRow("ID") = "-10000"
        dataRow("NAME") = "HeadActThrow"
        data.Rows.Add(dataRow)

        Return data
    End Function

    ''' <summary>
    ''' 入力値チェック
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckValues() As Boolean
        If Me.txtAuthor.TextLength = 0 Then
            MsgBox("作成者名を入力してください", MsgBoxStyle.OkOnly, "入力チェック")
            Return False
        End If
        If Me.txtJapName.TextLength = 0 Then
            MsgBox("日本語名を入力してください", MsgBoxStyle.OkOnly, "入力チェック")
            Return False
        End If
        If Me.txtEngName.TextLength = 0 Then
            MsgBox("英語名を入力してください", MsgBoxStyle.OkOnly, "入力チェック")
            Return False
        End If
        If Me.chkProperty1.Checked = False AndAlso Me.chkProperty2.Checked = False AndAlso Me.chkProperty3.Checked = False _
        AndAlso Me.chkProperty4.Checked = False AndAlso Me.chkProperty5.Checked = False AndAlso Me.chkProperty6.Checked = False _
        AndAlso Me.chkProperty7.Checked = False AndAlso Me.chkProperty8.Checked = False AndAlso Me.chkProperty9.Checked = False _
        AndAlso Me.chkProperty10.Checked = False AndAlso Me.chkProperty11.Checked = False AndAlso Me.chkProperty12.Checked = False _
        AndAlso Me.chkProperty13.Checked = False AndAlso Me.chkProperty14.Checked = False AndAlso Me.chkProperty15.Checked = False _
        AndAlso Me.chkProperty16.Checked = False Then
            MsgBox("属性一覧から最低一つは選択してください", MsgBoxStyle.OkOnly, "入力チェック")
            Return False
        End If

        If Me.chkProperty16.Checked = False Then
            If MessageBox.Show("CNPC属性にチェックが入っていませんが、よろしいですか?", "入力チェック", MessageBoxButtons.OKCancel) = System.Windows.Forms.DialogResult.Cancel Then
                Return False
            End If
        End If

        If Me.txtMeleeElemPower.TextLength = 0 Then
            MsgBox("素手格闘属性強度を入力してください", MsgBoxStyle.OkOnly, "入力チェック")
            Return False
        End If

        If Long.Parse(Me.txtMeleeElemPower.Text) < 200 Or Long.Parse(Me.txtMeleeElemPower.Text) > 99999 Then
            MsgBox("素手格闘属性強度は200~99999の値で設定してください", MsgBoxStyle.OkOnly, "入力チェック")
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' txtファイル書き込み用のデータを作成する
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CreateStringData() As String
        Dim str As New StringBuilder()
        '基本部分---------------------------------------------------------------------------------
        'ヘッダ
        str.Append("%Elona Custom Npc" + vbCrLf)
        str.Append(vbCrLf)
        '作成者
        str.Append("author." + vbTab + vbTab)
        str.Append("""" + Me.txtAuthor.Text + """" + vbCrLf)
        '名前
        str.Append("name." + vbTab + vbTab)
        str.Append("""" + Me.txtEngName.Text + "," + Me.txtJapName.Text + """" + vbCrLf)
        '種族
        str.Append("race." + vbTab + vbTab)
        str.Append("""" + Me.cmbRace.SelectedValue.ToString() + """" + vbCrLf)
        '職業
        str.Append("class." + vbTab + vbTab)
        str.Append("""" + Me.cmbClass.SelectedValue.ToString() + """" + vbCrLf)
        'キャラ属性
        str.Append("filter." + vbTab + vbTab)
        str.Append("""" + Me.ReturnPropertyValues() + """" + vbCrLf)
        '初期レベル
        str.Append("level." + vbTab + vbTab)
        str.Append("""" + Me.cmbLevel.SelectedValue.ToString() + """" + vbCrLf)
        '関係性
        str.Append("relation." + vbTab)
        str.Append("""" + Me.cmbRelation.SelectedValue.ToString() + """" + vbCrLf)
        '性別
        str.Append("sex." + vbTab + vbTab)
        str.Append("""" + Me.cmbSex.SelectedValue.ToString() + """" + vbCrLf)
        '生成品質
        str.Append("fixLv." + vbTab + vbTab)
        str.Append("""" + Me.cmbFixLv.SelectedValue.ToString() + """" + vbCrLf)
        '生成頻度
        str.Append("rare." + vbTab + vbTab)
        str.Append("""" + Me.cmbRare.SelectedValue.ToString() + """" + vbCrLf)
        '生成条件
        str.Append("spawnType." + vbTab)
        str.Append("""" + Me.cmbSpawnType.SelectedValue.ToString() + """" + vbCrLf)
        '待機時行動
        str.Append("aiCalm." + vbTab + vbTab)
        str.Append("""" + Me.cmbAiCalm.SelectedValue.ToString() + """" + vbCrLf)
        '移動確率
        str.Append("aiMove." + vbTab + vbTab)
        str.Append("""" + Me.cmbAiMove.SelectedValue.ToString() + """" + vbCrLf)
        '適正距離
        str.Append("aiDist." + vbTab + vbTab)
        str.Append("""" + Me.cmbAiDist.SelectedValue.ToString() + """" + vbCrLf)
        '瀕死時行動
        str.Append("aiHeal." + vbTab + vbTab)
        str.Append("""" + Me.cmbAiHeal.SelectedValue.ToString() + """" + vbCrLf)
        '基本行動1~5
        str.Append("aiAct." + vbTab + vbTab)
        str.Append("""" + Me.cmbAiAct1.SelectedValue.ToString())
        str.Append("," + Me.cmbAiAct2.SelectedValue.ToString())
        str.Append("," + Me.cmbAiAct3.SelectedValue.ToString())
        str.Append("," + Me.cmbAiAct4.SelectedValue.ToString())
        str.Append("," + Me.cmbAiAct5.SelectedValue.ToString() + """" + vbCrLf)
        '特殊行動確率
        str.Append("aiActSubFreq." + vbTab)
        str.Append("""" + Me.cmbAiActSubFreq.SelectedValue.ToString() + """" + vbCrLf)
        '特殊行動1~5
        str.Append("aiActSub." + vbTab)
        str.Append("""" + Me.cmbAiActSub1.SelectedValue.ToString())
        str.Append("," + Me.cmbAiActSub2.SelectedValue.ToString())
        str.Append("," + Me.cmbAiActSub3.SelectedValue.ToString())
        str.Append("," + Me.cmbAiActSub4.SelectedValue.ToString())
        str.Append("," + Me.cmbAiActSub5.SelectedValue.ToString() + """" + vbCrLf)
        '素手格闘属性強度
        str.Append("meleeElem." + vbTab)
        str.Append("""" + Me.cmbMeleeElem.SelectedValue.ToString() + "," + Me.txtMeleeElemPower.Text + """" + vbCrLf)
        '耐性
        str.Append("regist." + vbTab + vbTab)
        str.Append("""" + Me.ReturnRegistValues() + """" + vbCrLf)
        '補正
        str.Append("bitOn." + vbTab + vbTab)
        str.Append("""" + Me.ReturnBitValues() + """" + vbCrLf)
        str.Append(vbCrLf)
        '各種セリフテキスト(未実装)-----------------------------------------------------------------------------------------
        '待機・戦闘状態関連テキスト
        str.Append(Me.ReturnTextCalmValues())


        str.Append("%endTxt")

        Return str.ToString()
    End Function

    ''' <summary>
    ''' キャラ属性の書き込み用データを返す
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ReturnPropertyValues() As String
        Dim str As New StringBuilder()

        str.Append("/")
        If Me.chkProperty1.Checked = True Then
            str.Append("man/")
        End If
        If Me.chkProperty2.Checked = True Then
            str.Append("dragon/")
        End If
        If Me.chkProperty3.Checked = True Then
            str.Append("undead/")
        End If
        If Me.chkProperty4.Checked = True Then
            str.Append("slime/")
        End If
        If Me.chkProperty5.Checked = True Then
            str.Append("fire/")
        End If
        If Me.chkProperty6.Checked = True Then
            str.Append("sf/")
        End If
        If Me.chkProperty7.Checked = True Then
            str.Append("yeek/")
        End If
        If Me.chkProperty8.Checked = True Then
            str.Append("mino/")
        End If
        If Me.chkProperty9.Checked = True Then
            str.Append("wild/")
        End If
        If Me.chkProperty10.Checked = True Then
            str.Append("pawn/")
        End If
        If Me.chkProperty11.Checked = True Then
            str.Append("shopguard/")
        End If
        If Me.chkProperty12.Checked = True Then
            str.Append("rogue/")
        End If
        If Me.chkProperty13.Checked = True Then
            str.Append("cat/")
        End If
        If Me.chkProperty14.Checked = True Then
            str.Append("ether/")
        End If
        If Me.chkProperty15.Checked = True Then
            str.Append("horse/")
        End If
        If Me.chkProperty16.Checked = True Then
            str.Append("cnpc/")
        End If

        Return str.ToString()
    End Function

    ''' <summary>
    ''' 耐性の書込み用データを返す
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ReturnRegistValues() As String
        Dim str As New StringBuilder()

        If Me.dgvRegistElem.RowCount = 0 Then
            Return "64,0"
        End If

        For i As Integer = 0 To Me.dgvRegistElem.RowCount - 1
            If i <> 0 Then
                str.Append(",")
            End If
            str.Append(Me.dgvRegistElem.Rows(i).Cells(0).Value.ToString() + "," + Me.dgvRegistElem.Rows(i).Cells(2).Value.ToString())
        Next

        Return str.ToString()
    End Function

    ''' <summary>
    ''' 補正の書込み用データを返す
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ReturnBitValues() As String
        Dim str As New StringBuilder()

        If Me.dgvBit.RowCount = 0 Then
            Return "0"
        End If

        For i As Integer = 0 To Me.dgvBit.RowCount - 1
            If i <> 0 Then
                str.Append(",")
            End If
            str.Append(Me.dgvBit.Rows(i).Cells(0).Value.ToString())
        Next

        Return str.ToString()
    End Function

    ''' <summary>
    ''' テキスト関連(待機・戦闘状態関連)の書き込み用データを返す
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ReturnTextCalmValues() As String
        Dim str As New StringBuilder()

        With Me.SendTextData.Text_Calm
            str.Append("//////////////////////////////////////////////////////////" + vbCrLf)
            str.Append("■待機・戦闘状態関連テキスト" + vbCrLf)
            str.Append("//////////////////////////////////////////////////////////" + vbCrLf)
            If .txtCalm.Count > 0 Then
                str.Append("%txtCalm,JP" + vbCrLf)
                For i As Integer = 0 To .txtCalm.Count - 1
                    str.Append(.txtCalm(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txtWelcome.Count > 0 Then
                str.Append("%txtWelcome,JP" + vbCrLf)
                For i As Integer = 0 To .txtWelcome.Count - 1
                    str.Append(.txtWelcome(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txtakita.Count > 0 Then
                str.Append("%txtakita,JP" + vbCrLf)
                For i As Integer = 0 To .txtakita.Count - 1
                    str.Append(.txtakita(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txturusai.Count > 0 Then
                str.Append("%txturusai,JP" + vbCrLf)
                For i As Integer = 0 To .txturusai.Count - 1
                    str.Append(.txturusai(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txtthrowrock.Count > 0 Then
                str.Append("%txtthrowrock,JP" + vbCrLf)
                For i As Integer = 0 To .txtthrowrock.Count - 1
                    str.Append(.txtthrowrock(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txtbravo.Count > 0 Then
                str.Append("%txtbravo,JP" + vbCrLf)
                For i As Integer = 0 To .txtbravo.Count - 1
                    str.Append(.txtbravo(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txtnoru.Count > 0 Then
                str.Append("%txtnoru,JP" + vbCrLf)
                For i As Integer = 0 To .txtnoru.Count - 1
                    str.Append(.txtnoru(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txtoriru.Count > 0 Then
                str.Append("%txtoriru,JP" + vbCrLf)
                For i As Integer = 0 To .txtoriru.Count - 1
                    str.Append(.txtoriru(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txtparasite.Count > 0 Then
                str.Append("%txtparasite,JP" + vbCrLf)
                For i As Integer = 0 To .txtparasite.Count - 1
                    str.Append(.txtparasite(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txtumare.Count > 0 Then
                str.Append("%txtumare,JP" + vbCrLf)
                For i As Integer = 0 To .txtumare.Count - 1
                    str.Append(.txtumare(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txttobidasi.Count > 0 Then
                str.Append("%txttobidasi,JP" + vbCrLf)
                For i As Integer = 0 To .txttobidasi.Count - 1
                    str.Append(.txttobidasi(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txttoketa.Count > 0 Then
                str.Append("%txttoketa,JP" + vbCrLf)
                For i As Integer = 0 To .txttoketa.Count - 1
                    str.Append(.txttoketa(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txtkunren.Count > 0 Then
                str.Append("%txtkunren,JP" + vbCrLf)
                For i As Integer = 0 To .txtkunren.Count - 1
                    str.Append(.txtkunren(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txtAggro.Count > 0 Then
                str.Append("%txtAggro,JP" + vbCrLf)
                For i As Integer = 0 To .txtAggro.Count - 1
                    str.Append(.txtAggro(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txtDead.Count > 0 Then
                str.Append("%txtDead,JP" + vbCrLf)
                For i As Integer = 0 To .txtDead.Count - 1
                    str.Append(.txtDead(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txtKilled.Count > 0 Then
                str.Append("%txtKilled,JP" + vbCrLf)
                For i As Integer = 0 To .txtKilled.Count - 1
                    str.Append(.txtKilled(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txthinsi.Count > 0 Then
                str.Append("%txthinsi,JP" + vbCrLf)
                For i As Integer = 0 To .txthinsi.Count - 1
                    str.Append(.txthinsi(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            Dim PrvName As String = String.Empty  '1つ前のキャラ名を保持
            If .txtallykilledName.Count > 0 And .txtallykilled.Count > 0 Then
                For i As Integer = 0 To .txtallykilled.Count - 1
                    If PrvName <> .txtallykilledName(i) Then
                        str.Append(vbCrLf)
                        str.Append("%txtallykilled" + .txtallykilledName(i) + ",JP" + vbCrLf)
                    End If
                    str.Append(.txtallykilled(i) + vbCrLf)
                    PrvName = .txtallykilledName(i)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txtallykilleddefault.Count > 0 Then
                str.Append("%txtallykilleddefault,JP" + vbCrLf)
                For i As Integer = 0 To .txtallykilleddefault.Count - 1
                    str.Append(.txtallykilleddefault(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

            If .txtnikorose.Count > 0 Then
                str.Append("%txtnikorose,JP" + vbCrLf)
                For i As Integer = 0 To .txtnikorose.Count - 1
                    str.Append(.txtnikorose(i) + vbCrLf)
                Next
                str.Append("%END" + vbCrLf)
                str.Append("------------------------------------------------------------" + vbCrLf)
                str.Append(vbCrLf)
            End If

        End With

        str.Append(vbCrLf)

        Return str.ToString()
    End Function

#End Region


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New TextEditForm(SendTextData)

        f.ShowDialog()

        f.Close()
    End Sub

   
End Class
