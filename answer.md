## 振り返り

Windows10でもBash on Windowsでもnpm testが上手く動かなかったので、あきらめて別のPCの本物のUbuntu16.04で動かした。  
実行環境の試行に1時間くらい、実装は5分。

#### どのように実装手順を考えたか

最初にvalidを見て、4種類の出力があることをまず確認。  
invalidを見て、`invalid`を出力すべきだと確認。  
入力と出力が1対1対応しているのを確認。

3の倍数で3が無い場合、3の倍数で3がある場合、3の倍数でなく3がある場合、いずれでもない場合を発見したのでコーディングにした。

#### 実装の際に注意した点、工夫した点

2重の分岐があるのでif文の数を減らそうと思った。

#### 発生した問題や難しかった箇所、及びその対処

Windows上での実行。
`dump`だと思っていたら`dumb`だった。  

#### その他

C#の項目があったので思わず選んでみたがmonoだったので、dotnetコマンドとproject.jsonを使う、.NET Coreの方が良かった。
`dotnet new`でproject.jsonを作り、codecheck.ymlを以下のようにすれば動きそう。
``` yml
build:
# - mcs "src/*.cs" -out:TheApp.exe
 - dotnet build
env:
#  APP_COMMAND: mono TheApp.exe
  APP_COMMAND: dotnet run
test: mocha

```