# dotnet_state_store_fluxor_example1

## 概要

.NET 用の状態管理ライブラリ Fluxor の一番簡単なチュートリアルを実装してみた。

Fluxor  
https://github.com/mrpmorris/Fluxor

↓ Fluxor の構成図  
https://github.com/mrpmorris/Fluxor/blob/master/Docs/README.md

↓ 今回やったチュートリアル  
Fluxor - Basic concepts  
https://github.com/mrpmorris/Fluxor/tree/master/Source/Tutorials/01-BasicConcepts/01A-StateActionsReducersTutorial

## 環境
```
> dotnet --info
.NET SDK:
 Version:           8.0.100   
 Commit:            57efcf1350
 Workload version:  8.0.100-manifests.6c33ef20

ランタイム環境:
 OS Name:     Windows
 OS Version:  10.0.19045
 OS Platform: Windows
 RID:         win-x64
 Base Path:   C:\Program Files\dotnet\sdk\8.0.100\

インストール済みの .NET ワークロード:
 Workload version: 8.0.100-manifests.6c33ef20
```

## 構築
```
dotnet new console -o .
dotnet new gitignore
dotnet add package Microsoft.Extensions.DependencyInjection
dotnet add package Fluxor
```

## 実行
```
dotnet run
```

## 実行結果
* 1 を入力すると ClickCount がインクリメントされた後、現在の ClieckCount の値が表示される
* x を入力するとアプリが終了する

```
> dotnet run
Initializing store
1: Increment counter
x: Exit
> 1

==========================> CounterState
ClickCount is 1
<========================== CounterState

1: Increment counter
x: Exit
> 1

==========================> CounterState
ClickCount is 2
<========================== CounterState

1: Increment counter
x: Exit
> 1

==========================> CounterState
ClickCount is 3
<========================== CounterState

1: Increment counter
x: Exit
> x
Program terminated
```
