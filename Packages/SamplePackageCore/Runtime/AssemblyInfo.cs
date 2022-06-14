using System.Runtime.CompilerServices;

// 指定したdllから、internalアクセスレベルへのアクセスを許可する
[assembly: InternalsVisibleTo("SamplePackage")] //adfで定義した名前と一致させる
