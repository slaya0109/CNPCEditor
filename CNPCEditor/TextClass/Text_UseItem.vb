''' <summary>
''' アイテムを使用する/された時のテキスト保持クラス
''' </summary>
''' <remarks></remarks>
Public Class Text_UseItem
    ''' <summary>媚薬入りの食べ物を食べた時</summary>
    Public Property txtbiyaku As List(Of String)
    ''' <summary>媚薬で乳や卵を産む時</summary>
    Public Property txttiti As List(Of String)
    ''' <summary>媚薬を渡されて叩き割る時</summary>
    Public Property txtsaite As List(Of String)
    ''' <summary>聴診器を当てた時</summary>
    Public Property txtkya As List(Of String)
    ''' <summary>聴診器を外した時</summary>
    Public Property txttyohazusu As List(Of String)
    ''' <summary>紐で縛った時</summary>
    Public Property txtsibaru As List(Of String)
    ''' <summary>紐をほどいた時</summary>
    Public Property txthodoku As List(Of String)
    ''' <summary>サンドバッグに吊るされる時</summary>
    Public Property txtturusu As List(Of String)
    ''' <summary>サンドバッグに吊るされている時</summary>
    Public Property txtsand As List(Of String)
    ''' <summary>サンドバッグに吊るされて殴られている時</summary>
    Public Property txtsnaguru As List(Of String)
    ''' <summary>サンドバッグから降ろされる時</summary>
    Public Property txtsorosu As List(Of String)
    ''' <summary>おみやげを渡された時</summary>
    Public Property txtomiyage As List(Of String)
    ''' <summary>結婚指輪、首輪を渡された時「顔を赤らめた」の後</summary>
    Public Property txtyubikubi As List(Of String)
    ''' <summary>結婚指輪、首輪を取り上げようとした時「飲み込んだ」の後</summary>
    Public Property txttoriage As List(Of String)
    ''' <summary>腐った物を食べた時</summary>
    Public Property txtsibui As List(Of String)
    ''' <summary>生肉を食べた時</summary>
    Public Property txtnamaniku As List(Of String)
    ''' <summary>生の小麦粉を食べた時</summary>
    Public Property txtkona As List(Of String)
    ''' <summary>生麺を食べた時</summary>
    Public Property txtnamamen As List(Of String)
    ''' <summary>ミルクを飲んだ時</summary>
    Public Property txtmilk As List(Of String)
    ''' <summary>呪われたミルクを飲んだ時</summary>
    Public Property txtmilkcurse As List(Of String)
    ''' <summary>酒を飲んだ時</summary>
    Public Property txtsake As List(Of String)
    ''' <summary>呪われた酒を飲んだ時</summary>
    Public Property txtsakecurse As List(Of String)
    ''' <summary>酔い状態の時</summary>
    Public Property txtyopparai As List(Of String)
    ''' <summary>未調理の物を食べた時「平凡な味だ」など</summary>
    Public Property txtheibon As List(Of String)
    ''' <summary>ランク1~2の料理を食べた時</summary>
    Public Property txt1_2 As List(Of String)
    ''' <summary>ランク3~4の料理を食べた時</summary>
    Public Property txt3_4 As List(Of String)
    ''' <summary>ランク5~6の料理を食べた時</summary>
    Public Property txt5_6 As List(Of String)
    ''' <summary>ランク7~8の料理を食べた時</summary>
    Public Property txt7_8 As List(Of String)
    ''' <summary>ランク9の料理を食べた時</summary>
    Public Property txt9saiko As List(Of String)
    ''' <summary>自動食事をしようとして手元に食べ物が無かった時</summary>
    Public Property txtonaka As List(Of String)
    ''' <summary>○○のエロ本を読んでいる時</summary>
    Public Property txtpornobook_ As List(Of String)
    ''' <summary>エロ本を読んでいる時</summary>
    Public Property txtpornobookdefault As List(Of String)
End Class
