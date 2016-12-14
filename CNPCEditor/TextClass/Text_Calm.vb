''' <summary>
''' 待機時・戦闘状態関連のテキストを保持するクラス
''' </summary>
''' <remarks></remarks>
Public Class Text_Calm
    Sub New()

    End Sub

    ''' <summary>通常の待機状態の時</summary>
    Public Property txtCalm As New List(Of String)
    ''' <summary>出迎えの時</summary>
    Public Property txtWelcome As New List(Of String)
    ''' <summary>演奏を聞かされて飽きた時</summary>
    Public Property txtakita As New List(Of String)
    ''' <summary>演奏を聞かされて投石する時</summary>
    Public Property txturusai As New List(Of String)
    ''' <summary>演奏を聞かされた際にデフォルトだと「○○は石を投げた」となる部分</summary>
    Public Property txtthrowrock As New List(Of String)
    ''' <summary>演奏を聞かされて褒める時</summary>
    Public Property txtbravo As New List(Of String)
    ''' <summary>乗馬される時</summary>
    Public Property txtnoru As New List(Of String)
    ''' <summary>乗馬状態を解除される時</summary>
    Public Property txtoriru As New List(Of String)
    ''' <summary>寄生された時</summary>
    Public Property txtparasite As New List(Of String)
    ''' <summary>寄生されている時。デフォルトだと「何かが産まれそうだよ!」の部分</summary>
    Public Property txtumare As New List(Of String)
    ''' <summary>何かが腹を破って飛び出した時</summary>
    Public Property txttobidasi As New List(Of String)
    ''' <summary>エイリアンを溶かした時</summary>
    Public Property txttoketa As New List(Of String)
    ''' <summary>訓練所に行こうとして訓練費用が無かった時</summary>
    Public Property txtkunren As New List(Of String)
    ''' <summary>交戦する時</summary>
    Public Property txtAggro As New List(Of String)
    ''' <summary>ミンチにされた時</summary>
    Public Property txtDead As New List(Of String)
    ''' <summary>ミンチにした時</summary>
    Public Property txtKilled As New List(Of String)
    ''' <summary>瀕死の時</summary>
    Public Property txthinsi As New List(Of String)

    ''' <summary>特定の仲間がミンチにされた時</summary>
    Public Property txtallykilled As New List(Of String)
    ''' <summary>特定の仲間の名称</summary>
    Public Property txtallykilledName As New List(Of String)

    ''' <summary>仲間がミンチにされた時</summary>
    Public Property txtallykilleddefault As New List(Of String)
    ''' <summary>気が狂っている時</summary>
    Public Property txtnikorose As New List(Of String)

End Class
