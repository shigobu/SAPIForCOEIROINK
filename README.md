# SAPIForVOICEVOX
VOICEVOXをSAPIから見えるようにします。  
棒読みちゃんでテストしています。  
32bitでビルドしているので、64bitアプリからは見えないかもしれません。

# 開発環境
Microsoft Visual Studio Community 2019  
C#・C++

# ビルド方法
ソリューションを開き、ビルドを実行します。  
~~自動でCOMとして登録されます。SAPIに必要なレジストリの登録も自動で実行されます。~~  
インストーラプロジェクトを追加したので、ビルド時にレジストリ登録する機能はオフにしました。 
インストーラプロジェクトは自動でビルドされません。ソリューションエクスプローラーからSetupを右クリックしてビルドを選択し、ビルドしてください。 

# 使用方法
~~ビルドしたマシンでは、ビルド時にレジストリ登録されているので、そのまま棒読みちゃん等を起動すれば声質一覧に表示れているはずです。~~ インストーラプロジェクトを追加したので、ビルド時にレジストリ登録する機能はオフにしました。  

GitHubのReleaseからダウンロードができます。  
setup.exeを起動し、インストールしてください。  
インストール場所の初期値は「c:\SAPIForVOICEVOX」になっています。  
「C:\Program Files (x86)」へインストールしないでください。何故か正常にインストールできません。  

VOICEVOX本体が必要です。[VOICEVOX公式ホームページ](https://voicevox.hiroshiba.jp/)  
VOICEVOXエンジンの自動起動機能は実装していないので、あらかじめVOICEVOXを起動しておいてください。

# 追加したい機能等
- [x] インストーラ作成。  
- [x] VOICEVOXエンジンが見つからない場合に、音声で知らせる機能。
