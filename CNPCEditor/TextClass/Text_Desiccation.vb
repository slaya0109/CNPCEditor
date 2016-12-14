''' <summary>
''' 干渉(i)や冒険者関連のテキスト保持クラス
''' </summary>
''' <remarks></remarks>
Public Class Text_Desiccation
    ''' <summary>話しかけた時</summary>
    Public Property txtDialog As List(Of String)
    ''' <summary>婚約を申し込まれた時</summary>
    Public Property txtmarriage As List(Of String)
    ''' <summary>婚約を断る時</summary>
    Public Property txtyanwari As List(Of String)
    ''' <summary>遺伝子を残す時</summary>
    Public Property txtanata As List(Of String)
    ''' <summary>遺伝子を残すのを断る時</summary>
    Public Property txtiyayo As List(Of String)
    ''' <summary>子供を作る時</summary>
    Public Property txtkodukuri As List(Of String)
    ''' <summary>気持ちいい事を受ける時。デフォルトだと「なかなかの身体つきだ、買った」</summary>
    Public Property txtnakanaka As List(Of String)
    ''' <summary>気持ちいい事を受ける時。デフォルトだと「いくよ！」</summary>
    Public Property txtikuyo As List(Of String)
    ''' <summary>気持ちいい事をするで「やめる」を選んだ時。デフォルトだと「冷やかしか？」</summary>
    Public Property txtiyameru As List(Of String)
    ''' <summary>気持ちいい事をしている最中の時</summary>
    Public Property txtkuyasii As List(Of String)
    ''' <summary>気持ちいい事の事後</summary>
    Public Property txtjigo As List(Of String)
    ''' <summary>気持ちいい事が中断された時</summary>
    Public Property txtkaradake As List(Of String)
    ''' <summary>冒険者にした後話しかけた時</summary>
    Public Property txtpbou As List(Of String)
    ''' <summary>冒険者にした後アイテム交換をした時</summary>
    Public Property txtexthank As List(Of String)
    ''' <summary>冒険者にした後アイテム交換を持ちかけて、見合うアイテムを持っていないor交換をやめた時</summary>
    Public Property txtexhiya As List(Of String)
    ''' <summary>冒険者にした後護衛の依頼を持ちかけた時</summary>
    Public Property txtgoei As List(Of String)
    ''' <summary>冒険者にした後護衛を依頼した時</summary>
    Public Property txtyatou As List(Of String)
    ''' <summary>冒険者にした後護衛の依頼を持ちかけてやめた時</summary>
    Public Property txthihiya As List(Of String)
    ''' <summary>冒険者にした後仲間に誘って承諾された時</summary>
    Public Property txtumaku As List(Of String)
    ''' <summary>冒険者にした後仲間に誘ってお断りされた時(力の差)</summary>
    Public Property txttikara As List(Of String)
    ''' <summary>冒険者にした後仲間に誘ってお断りされた時(ペット枠0)</summary>
    Public Property txt0free As List(Of String)
    ''' <summary>冒険者にした後仲間に誘ってお断りされた時(友好度不足or雇用回数不足)</summary>
    Public Property txtokoto As List(Of String)
End Class
