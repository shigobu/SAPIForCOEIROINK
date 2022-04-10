[SAPI For VOICEVOX](https://github.com/shigobu/SAPIForVOICEVOX)
に統合しました。

# SAPI For COEIROINK

Windows標準の音声合成機能の音声としてCOEIROINKが追加ができます。  
![コンパネ音声合成](https://user-images.githubusercontent.com/32050537/131860902-7aedbd45-453a-4425-a33c-7cb4a2f2dcf1.png)  
SAPI5対応のアプリケーションから使用することができます。  
現在、古い方の音声合成機能に対応しています。コントロールパネル→音声認識→音声合成 で表示される音声認識のプロパティ画面の音声の選択ドロップダウンに追加されます。  
新しい方の、設定アプリ→時刻と言語→音声認識→音声→音声を選択するドロップダウンには表示されません。  
したがって、新しい方の音声合成機能しか対応していないアプリには対応していません。  

32bit版は、棒読みちゃんでテストしています。  
64bit版は、やります！アンコちゃんでテストしています。  

## 使用方法
GitHubのReleaseからダウンロードができます。  
setup.exeを起動し、インストールしてください。  
32bit版と64bit版が存在します。使用したいアプリケーションに応じて選択してください。  
両方インストールすることもできます。その場合、同じ場所にインストールしないでください。  
インストール場所の初期値は「c:\SAPIForCOEIROINK(32or64)」になっています。  
「C:\Program Files (x86)」へインストールしないでください。何故か正常にインストールできません。  

COEIROINK本体が必要です。[COEIROINK公式ホームページ](https://coeiroink.com/)  
COEIROINKエンジンの自動起動機能は実装していないので、あらかじめCOEIROINKを起動しておいてください。  

Windows Defender にウイルスとして検知されてしまうと報告をうけています。  
当ソフトには、ウイルスは含まれていませんので、誤検知です。  
ソースコードを公開しているので、そこから判断していただくと幸いです。  
ちなみに、ウイルスバスターでは、「脅威無し」の判定でした。    

### アンインストール
アンインストールは、Windowsの「設定」→「アプリ」→「アプリと機能」からアンインストールができます。  
アンインストールを実行しても、設定を保存したxmlファイルが削除されずに残ります。  
不要な場合は、手動で削除をしてください。

### 設定画面
バージョン1.1.0から設定画面を追加しました。  
インストールすると、スタートメニューの全てのアプリに追加されます。  
![設定画面・全般](https://user-images.githubusercontent.com/32050537/133756799-43cc7945-cf74-4c30-b232-275b7bd5cda9.png)
![設定画面・調声](https://user-images.githubusercontent.com/32050537/133757251-033eb099-99e8-48f8-b4d7-f74580e1d142.png)  

この画面で、音声のパラメータ等を調節できます。  
設定内容は、32bit版と64bit版でそれぞれ別に保存されます。  

## 英語辞書について
バージョン1.1.1から英語辞書を搭載しました。  
辞書の大元は、  
The CMU Pronouncing Dictionary(http://www.speech.cs.cmu.edu/cgi-bin/cmudict)  
を使用しています。  
これを、「モリカトロン開発ブログ」の「英語をカタカナ表記に変換してみる(https://tech.morikatron.ai/entry/2020/05/25/100000)」  
という記事に載っているコードを使用し、発音記号からカタカナへ変換しています。

実際にどのように置換されるかは、[shigobu/EnglishKanaDictionary](https://github.com/shigobu/EnglishKanaDictionary)のテストアプリで確認するのが簡単かと思います。

## ライセンス
このアプリのライセンスは、「MIT License」です。

また、COEIROINK本体及び各音声ライブラリの利用規約にも従ってください。  
[COEIROINK利用規約](https://coeiroink.com/terms)  
[つくよみちゃん音声](https://coeiroink.com/audio-character/tsukuyomi-chan)

## 開発環境
Microsoft Visual Studio Community 2019  
C#・C++

## ビルド方法
ソリューションを開き、ビルドを実行します。  
~~自動でCOMとして登録されます。SAPIに必要なレジストリの登録も自動で実行されます。~~  
インストーラプロジェクトを追加したので、ビルド時にレジストリ登録する機能はオフにしました。  
インストーラプロジェクトは自動でビルドされません。ソリューションエクスプローラーからSetupを右クリックしてビルドを選択し、ビルドしてください。  
同じく、Setupを右クリックしてインストールを選択すると、インストールができます。  

インストーラのビルドには、「Microsoft Visual Studio Installer Projects」の拡張機能が必要です。  
Visual Studioの「ツール」→「拡張機能」からインストールしてください。  

## フォルダ構成
SAPIForCOEIROINK：本体  
SAPIGetStaticValueLib：必要な定数を取得するc++のライブラリ  
SFVvCommon：C#で使用する共通ライブラリ  
Setting：設定アプリ  
Setup：32bitインストーラ  
Setup64：64bitインストーラ  
SetupCustomActions：インストーラのカスタムアクション  
StyleRegistrationTool：スタイル登録ツール  

