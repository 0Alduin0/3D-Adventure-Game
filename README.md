# ⚔️ 3D Adventure Game

**Unity** ve **C#** ile geliştirilmiş üç boyutlu bir macera oyunudur. Oyuncu, 3D bir dünyada keşif yaparak çeşitli görevleri tamamlamaya çalışır.

---

## 🎮 Hakkında

3D Adventure Game, Unity oyun motoru kullanılarak geliştirilen üçüncü şahıs (veya birinci şahıs) bir macera oyunudur. Oyuncu, 3D ortamda hareket ederek düşmanlarla savaşabilir, çevreyi keşfedebilir ve bölümleri tamamlayarak ilerleyebilir. Proje, Unity'nin 3D fizik sistemi, karakter kontrol mekanikleri ve sahne yönetimi gibi temel oyun geliştirme kavramlarını kapsar.

## 🕹️ Kontroller

| Tuş | İşlev |
|-----|-------|
| `W` `A` `S` `D` | Hareket (İleri, Sol, Geri, Sağ) |
| `Space` | Zıplama |
| `Mouse` | Kamera kontrolü / Bakış yönü |
| `Sol Tık` | Saldırı |
| `Shift` | Koşma |
| `E` | Etkileşim |

> *Not: Kontrol tuşları proje içindeki ayarlara göre farklılık gösterebilir.*

## ✨ Özellikler

- 3D karakter hareket ve kontrol sistemi
- Kamera takip sistemi (Third Person / First Person)
- Düşman yapay zekâsı (AI) ve savaş mekaniği
- Fizik tabanlı etkileşimler (Rigidbody, Collider)
- Seviye / bölüm tasarımı
- Animasyon sistemi (Animator, Animation Controller)
- UI elemanları (can barı, skor, menüler)

## 🔧 Kullanılan Teknolojiler

- **Motor:** Unity (3D)
- **Programlama Dili:** C# (%100)
- **Fizik:** Unity 3D Physics (Rigidbody, CharacterController, Collider)
- **Animasyon:** Unity Animator / Mecanim

## 📁 Proje Yapısı

```
3D-Adventure-Game/
├── Assets/            # Oyun varlıkları (scriptler, modeller, materyaller, sahneler, prefab'lar vb.)
├── Packages/          # Unity paket yöneticisi bağımlılıkları
├── ProjectSettings/   # Unity proje ayarları
├── .gitignore
└── .vsconfig
```

## 🚀 Başlangıç

### Gereksinimler

- **Unity Hub** kurulu olmalıdır.
- **Unity Editor** (kullanılan sürüm için `ProjectSettings/ProjectVersion.txt` dosyasını kontrol edin)

### Kurulum

1. Depoyu klonlayın:
   ```bash
   git clone https://github.com/0Alduin0/3D-Adventure-Game.git
   ```
2. **Unity Hub**'ı açın ve **"Open"** butonuna tıklayarak klonlanan proje klasörünü seçin.
3. Unity'nin tüm varlıkları içe aktarmasını bekleyin.
4. `Assets/Scenes` klasöründen ana sahneyi açın ve **Play** butonuna basın.

## 🤝 Katkıda Bulunma

Katkılarınızı bekliyoruz! Katkıda bulunmak için:

1. Depoyu **fork**'layın.
2. Yeni bir dal oluşturun: `git checkout -b ozellik/yeni-ozellik`
3. Değişikliklerinizi commit'leyin: `git commit -m 'Yeni özellik eklendi'`
4. Dalınıza push'layın: `git push origin ozellik/yeni-ozellik`
5. Bir **Pull Request** açın.

## 📜 Lisans

Bu proje açık kaynaklıdır. Lisans detayları için depoyu inceleyiniz.

## ⭐ Destek

Projeyi beğendiyseniz [GitHub](https://github.com/0Alduin0/3D-Adventure-Game) üzerinden ⭐ vermeyi unutmayın!
