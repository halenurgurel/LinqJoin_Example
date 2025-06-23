# LINQ ile Join Kullanımı - Yazarlar ve Kitaplar Örneği

Bu C# konsol uygulaması, iki farklı koleksiyondaki (`Authors` ve `Books`) verileri, **LINQ JOIN** işlemiyle ilişkilendirerek yazarların kitaplarını eşleştirir ve ekrana yazdırır.

---

## 🚀 Özellikler

- Yazarlar (`Authors`) ve kitaplar (`Books`) listeleri oluşturulur.
- Her yazar ve kitabın ID’si kullanılarak JOIN işlemi yapılır.
- Her yazarın yazdığı kitaplar bir arada listelenir.
- Uygulama, hem LINQ metot söz dizimiyle hem de sorgu söz dizimiyle JOIN örneği olarak uyarlanabilir.

---

## 📚 Kullanılan Sınıflar

### `Authors`
| Özellik    | Açıklama         |
|------------|------------------|
| AuthorId   | Yazarın benzersiz numarası |
| Name       | Yazarın adı      |

### `Books`
| Özellik    | Açıklama         |
|------------|------------------|
| BookId     | Kitabın benzersiz numarası |
| Title      | Kitabın adı      |
| AuthorId   | Kitabın yazar numarası     |

---

## 💻 Nasıl Çalışır?

1. Önce yazarlar ve kitaplardan oluşan iki liste oluşturulur.
2. LINQ JOIN ile, yazarların ve kitapların `AuthorId`’leri eşleştirilir.
3. Elde edilen yeni koleksiyon, her satırda yazar ve ona ait kitap olarak ekrana yazılır.

---

## 🧩 Örnek Kod

```csharp
var authorsWithBooks = from author in authors
                       join book in books
                       on author.AuthorId equals book.AuthorId
                       select new
                       {
                           AuthorName = author.Name,
                           BookTitle = book.Title,
                       };

foreach (var item in authorsWithBooks)
{
    Console.WriteLine($"Yazarın Adı: {item.AuthorName} \nKitabın Adı: {item.BookTitle}");
    Console.WriteLine();
}

```

## Örnek Çıktı
**Yazarın Adı:** Gabriel Garcia Marquez 

**Kitabın Adı:** Kolera Günlerinde Aşk

**Yazarın Adı:**  Sally Rooney 

**Kitabın Adı:** Normal İnsanlar

**Yazarın Adı:** Virgina Woolf 

**Kitabın Adı:** Orlando

**Yazarın Adı:** Virgina Woolf

**Kitabın Adı:** Kendine Ait Bir Oda

**Yazarın Adı:** Arkadi, Boris Strugatski

**Kitabın Adı:** Tanrı Olmak Zor İş

## 🎯 Öğrenilen LINQ Konuları
JOIN işlemi

Sorgu söz dizimiyle LINQ

Koleksiyonlar arası ilişki kurma

Anonim tiplerle çıktı oluşturma
