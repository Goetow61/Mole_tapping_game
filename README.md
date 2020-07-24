# もぐら叩きゲーム

<img src="https://user-images.githubusercontent.com/57985382/79054372-3760c100-7c7f-11ea-9263-08078adb3498.PNG" width="50%">

## 内容
穴から出てくるモグラをひたすらにクリックして叩きます。

## 環境
Unity 2018.4.3f1
Visual Studio

## 機能
もぐら叩きゲーム
スコアの記録・表示

## 仕組み
クリックイベントを主に活用している。

## その他
履歴のソートの書き方を調べるのに手間取った。
Array.Sort(jag, (x, y) => String.Compare(y[index], x[index]));
という短い記述もなかなか見つけられなかった。
