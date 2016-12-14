''' <summary>
''' スキル使用時のテキスト保持クラス
''' </summary>
''' <remarks></remarks>
Public Class Text_UseSkill
    ''' <summary>PCの演奏に合わせて歌っている時</summary>
    Public Property txtsing As List(Of String)
    ''' <summary>レイハンドを使う時</summary>
    Public Property txtlayhand As List(Of String)
    ''' <summary>罵倒する時</summary>
    Public Property txtabuse As List(Of String)
    ''' <summary>デフォルトだと「○○は××を罵倒した」となる部分</summary>
    Public Property txtbatou As List(Of String)
    ''' <summary>スウォームを使用した時のメッセージ「スウォーム！」の部分</summary>
    Public Property txtswarm As List(Of String)
    ''' <summary>相手に寄生した時のメッセージ「なにかを送り込んだ」の部分</summary>
    Public Property txtkisei As List(Of String)
    ''' <summary>狂気の眼差し「蛆虫が湧き出るのを見た」の部分</summary>
    Public Property txtuzimushi As List(Of String)
    ''' <summary>特定の魔法を使用した時</summary>
    Public Property txtcastmagic As List(Of String)
    ''' <summary>魔法を使用した時「魔法を詠唱した」の部分</summary>
    Public Property txtcaststyle As List(Of String)
    ''' <summary>自己回復、自己強化系の魔法を使用</summary>
    Public Property txtcaststyle2 As List(Of String)
    ''' <summary>ブースト使用前</summary>
    Public Property txtactbefore647 As List(Of String)
    ''' <summary>ブースト使用後</summary>
    Public Property txtactafter647 As List(Of String)

End Class
