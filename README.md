# BasicCaculator

C# で記述された電卓で、式の計算と簡単な関数をサポートしています。

<img src="BasicCaculator/Docs/Image/ScreenShot2024-07-20%20164147.png" alt="Calculator Screenshot" width="450px" />

## 機能
基本的な操作を提供する標準の電卓機能。

## 使用方法

他のシンプルな電卓と同じ UI。
このプロジェクトでは、.net 8 core が提供するライブラリのみを使用しました。
テキストボックスの桁数が20以上になったら、別の計算しないといけません。

## 作業の開始
前提条件:
- コンピューターで Windows 11、ビルド 22000 以降を実行している必要があります。
- [Visual Studio](https://developer.microsoft.com/en-us/windows/downloads) の最新バージョンをインストールします (無料のコミュニティ エディションで十分です)。
- C# .net 8.0 をインストールします。
- コードを取得します:
```
git clone https://github.com/NLkhuyen/BasicCaculator.git
```
- Visual Studio で [src\BasicCaculator.sln](/src/BasicCaculator.sln) を開き、電卓アプリをビルドして実行します。

## 自動的な単体テスト
- xUnit を使用したシンプルな単体テスト。
- Visual Studio にインポートした後、単体テスト ロジック メソッドに対してテストを実行するだけです。
