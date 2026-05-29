# Asal Sayı Toplamı

Kullanıcıdan alınan **N** değerine kadar (dahil) olan tüm asal sayıların toplamını hesaplayan konsol uygulaması.

## Örnek

`N = 10` için asal sayılar: 2, 3, 5, 7 → toplam: **17**

## Gereksinimler

- [.NET Framework 4.6.1](https://dotnet.microsoft.com/download/dotnet-framework/net461) veya üzeri
- Windows üzerinde derleme için [Visual Studio](https://visualstudio.microsoft.com/) veya MSBuild

## Çalıştırma

### Visual Studio

1. `asal sayi toplami.sln` dosyasını açın
2. **F5** ile çalıştırın veya **Derle → Çözümü Derle** (Ctrl+Shift+B)

### Komut satırı (MSBuild)

```bash
msbuild "asal sayi toplami.sln" /p:Configuration=Release
```

Derleme sonrası çalıştırılabilir dosya:

```
asal sayi toplami/bin/Release/asal sayi toplami.exe
```

Program sizden bir üst sınır (**N**) ister; girdikten sonra asal sayıların toplamını ekrana yazar.

## Proje yapısı

```
asal-sayi-toplami/
├── asal sayi toplami.sln
└── asal sayi toplami/
    ├── Program.cs          # Ana program
    ├── App.config
    └── asal sayi toplami.csproj
```

## Lisans

Bu proje [MIT lisansı](LICENSE) altında yayınlanmıştır.
