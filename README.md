# 🧩 Entity Framework Core — Hızlı Rehber *(Kişisel Notlardan Derleme)*
---

## 🗂️ İçindekiler

* Neden EF Core?]
* Yaklaşımlar: Code First vs Database First]
* DbContext & DbSet]
* Migrations — Temel Komutlar]
* Model Yapılandırma]
* İlişkiler (Relationships)
* İlişkili Veri Yükleme
* Kalıtım (TPH/TPT)
* Owned & Keyless Entity Types
* İndeksler & Check Constraints
* Sorgulama, Join ve Ham SQL
* Sayfalama (Pagination)
* Global Query Filters (Soft Delete, Multi‑Tenancy)
* Stored Procedure & Function
* Projeksiyon & AutoMapper
* Transaction & Concurrency
* Hızlı Başlangıç Rehberi
* Sık Karşılaşılan İpuçları

---

## 🚀 Neden EF Core?

* **ORM**: Nesneleri tablo satırlarına güvenli şekilde map’ler.
* **LINQ**: Tür güvenli sorgular; EF, bunları SQL’e dönüştürür.
* **Taşınabilirlik**: Birçok ilişkisel VT desteği.
* **Üretkenlik**: Migration, ilişkiler, yükleme stratejileri, filtreler vb.

---

## 🧭 Yaklaşımlar: Code First vs Database First

**Database First**

* Önce veritabanı ve tablolar; sonra *scaffold* ile kod üretimi.
* Manuel/yarı otomatik süreç; hazır VT’lerde pratik.

**Code First**

* Önce kod; **Migrations** ile VT senkronu.
* Otomatize ve sürümlenebilir şema değişiklikleri.

> 💡 **Pratik öneri:** Hazır VT için **Scaffold** ile başla, sonra **Code First** akışına dön ve şemayı Migration’larla yönet.

---

## 🧱 DbContext & DbSet

* `DbContext`: Veritabanına açılan oturum (unit of work + repo davranışı).
* `DbSet<TEntity>`: Tablonun temsilcisi.
* **İzleme (Change Tracker)**: State makineleri (Added/Modified/Deleted/Unchanged/Detached).
* **Performans**: Salt okunur listeler için `AsNoTracking()` kullan.

**Örnek**

---

## 🔧 Migrations — Temel Komutlar

> 📝 **Not:** Migration dosyalarını elle silmeyin; komutları kullanın. Geri dönüş gerekiyorsa hedef migration adına `database update` yapın.

---

## 🧩 Model Yapılandırma

* **Conventions**: 
* **Data Annotations**: 
* **Fluent API**: 


---

## 🤝 İlişkiler (Relationships)

* **1‑N**: `Category (Principal)` – `Product (Dependent)` + `CategoryId` FK.
* **1‑1**: `Product` – `ProductFeature` (FK’yi açık belirt veya Fluent ile tanımla).
* **N‑N**: `Student` – `Teacher`; EF Core ara tabloyu (join table) üretebilir, gerekirse özelleştir.
* **Delete Behaviors**: `Cascade`, `Restrict`, `SetNull`, `NoAction`.


---

## 📦 İlişkili Veri Yükleme

* **Eager**: `Include` / `ThenInclude` (tek SQL + join)
* **Explicit**: `context.Entry(entity).Reference(...).Load()` / `Collection(...).Load()`
* **Lazy**: Proxy + `virtual` navigation; erişildiğinde sorgular (dikkat: N+1 yapabilir)

---

## 🧬 Kalıtım (TPH/TPT)

* **TPH (Table‑per‑Hierarchy)**: Tek tablo + `Discriminator` sütunu.
* **TPT (Table‑per‑Type)**: Her türe bir tablo; `ToTable()` ile eşle.

---

## 🧾 Owned & Keyless Entity Types

* **Owned**: Kimliksiz, ana varlığa gömülü değer nesneleri (adres vb.).
* **Keyless**: PK’siz view/SQL sonuçları; *insert/update/delete* yok, sadece **okuma**.

---

## 📐 İndeksler & Check Constraints

---

## 🔍 Sorgulama, Join ve Ham SQL

* **LINQ**: `Where/Select/First/Single/Find`. Sunucu tarafı çevrimi mümkün değilse, client tarafı değerlendirilir.
* **Join**: Navigation varsa join yazma; yoksa LINQ ile inner/left benzeri kur.
* **Ham SQL**: `FromSqlRaw`, `FromSqlInterpolated`, `ExecuteSqlRaw`.

---

## 📄 Sayfalama (Pagination)

---

## 🌐 Global Query Filters (Soft Delete, Multi‑Tenancy)

* İhtiyaç halinde `IgnoreQueryFilters()` ile baypas edilebilir.

---

## 🧪 Stored Procedure & Function

* **SP** ile: karmaşık/performans kritik sorgular, insert/update/delete akışları.
* **Function**: Table‑valued / Scalar‑valued fonksiyon eşlemeleri.

---

## 🎯 Projeksiyon & AutoMapper

* **Amaç**: Kullanıcıya sadece gereken alanları döndür, gereksiz izleme/kopyalamadan kaçın.
* **Yöntem**: `Select` ile DTO; AutoMapper kullanıyorsan `ProjectTo` ile sadece gerekli kolonları çek.

---

## 🔒 Transaction & Concurrency

* **EF’de her `SaveChanges()` kendi transaction’ını kullanır**; birden fazla adımı tek bütün yapmak için manuel transaction aç.
* **İzolasyon Seviyeleri**: Read Uncommitted, Read Committed, Repeatable Read, Serializable, Snapshot.
* **Optimistic Concurrency** (varsayılan): `rowversion/timestamp` ile çakışma algıla ve yönet.

---

## ⚡ Hızlı Başlangıç Rehberi

1. **Bağlantı**: `appsettings.json` → ConnectionString → `Program.cs` → `AddDbContext`.
2. **Entity’ler**: POCO sınıfları + minimal anotasyon.
3. **Fluent API**: `OnModelCreating` ile kurallar/ilişkiler/indeksler.
4. **Migration**: `migrations add` → `database update`.
5. **Sorgular**: `AsNoTracking`, `Select`/`ProjectTo`, `Include` gerekirse.
6. **Validasyon & Kısıtlar**: `HasCheckConstraint`, `HasIndex`.
7. **Bakım**: Global filtreler, loglama (`TagWith`), script üretimi.

---

## 💡 Sık Karşılaşılan İpuçları

* `AsNoTracking()` performans kazandırır (read‑only senaryolar).
* Navigation için **eager** tercih et; **lazy** N+1’e dikkat.
* Migration geri alacaksan **komut** kullan; dosya silme.
* View/kompleks sorgu için **Keyless** kullan; DML bekleme.
* FK’nin `nullable` olması **SetNull** için gereklidir.
* Komut tabanlı raporlama için `migrations script` üret ve versiyonla.
* `ToTable`/`HasColumnType` gibi Fluent API uzantıları için doğru paket/referansları eklediğinden emin ol (EF Core sürüm uyumu).

---


👤 Geliştirici
İrem Şentürk
