# Input Prompts

## Türkçe

Input Prompts, TextMeshPro kullanan metinlerde belirlediğiniz bir anahtar kelimeyi yakalayıp onu aktif input cihazına uygun bir ikonla değiştiren bir Unity paketidir.

Örneğin metinde:
`Press BUTTONPROMPT to Jump`

yazıyorsa, paket `BUTTONPROMPT` ifadesini oyuncunun kullandığı cihaza göre uygun sprite etiketiyle değiştirir.

Örnek çıktı:
`Press <sprite="Ps5_SpriteSheet" name="DualShock_buttonNorth"> to Jump`

Böylece oyuncu Xbox ile oynuyorsa Xbox ikonu, PlayStation ile oynuyorsa PlayStation ikonu, klavye/fare kullanıyorsa ilgili tuş ikonu gösterilir.

## Kurulum

Unity Package Manager üzerinden paketi şu Git URL ile ekleyebilirsiniz:

`https://github.com/SirMustafa/com.SirMust.inputprompts.git`

## Kullanım İçin Hazırlık

Önce kullanacağınız input görsellerini hazırlamanız gerekir. Bu görselleri şu siteden indirebilirsiniz:

`https://thoseawesomeguys.com/prompts/`

İsterseniz kendi hazır input görsellerinizi veya kendi sprite sheet’inizi de kullanabilirsiniz. Daha sonra bu görselleri bir sprite sheet haline getirin. Ardından sprite sheet’i Unity’ye import edin ve şu adımları uygulayın:

- Sprite sheet’i seçin
- `Open Sprite Editor` açın
- Görseli eşit parçalara bölün

Bölme işlemi bittikten sonra o sprite sheet’e sağ tıklayın ve şunu seçin:

`Create -> TextMeshPro -> Sprite Asset`

Kullanacağınız her platform için bu işlemi yapın.Örneğin:

- Keyboard
- Xbox
- PlayStation

Tüm sprite sheet’lerin TMP Sprite Asset dosyalarını oluşturduktan sonra Project penceresinde uygun bir yere sağ tıklayın ve şunu oluşturun:

`Create -> Input Prompt Sprite Library`

Bu paketle birlikte gelen ScriptableObject budur. Oluşturduğunuz `Input Prompt Sprite Library` objesinin içinde platformlara ayrılmış alanlar bulunur. Buradaki Keyboard, Xbox ve PlayStation alanlarına oluşturduğunuz TMP Sprite Asset dosyalarını atayın.

## Text Üzerinde Kullanım

Paketi kullanmak için TextMeshPro componenti olan bir objeye `Add Component` diyerek `SetTextToBox` scriptini ekleyin. Sonra Inspector içindeki alanları doldurun. Metin içinde değiştirilmesini istediğiniz anahtar kelimeyi yazın.

Örneğin:

`BUTTONPROMPT`

Bu kadar. Paket, aktif input cihazına göre doğru sprite etiketini üretir ve TextMeshPro metnini buna göre günceller.

---

## English

Input Prompts is a Unity package that detects a keyword inside TextMeshPro texts and replaces it with the correct icon for the active input device. For example, if your text contains:

`Press BUTTONPROMPT to Jump`

the package replaces `BUTTONPROMPT` with the correct sprite tag based on the player’s current device.

Example output:

`Press <sprite="Ps5_SpriteSheet" name="DualShock_buttonNorth"> to Jump`

This allows the UI to show an Xbox icon when the player uses Xbox, a PlayStation icon when the player uses PlayStation, or the correct key icon when using keyboard and mouse.

## Installation

You can add the package through Unity Package Manager using this Git URL:

`https://github.com/SirMustafa/com.SirMust.inputprompts.git`

## Setup

First, you need to prepare the input images you want to use.

You can download prompt images from:

`https://thoseawesomeguys.com/prompts/`

You can also use your own input images or your own sprite sheet if you already have one. After that, convert those images into a sprite sheet. Then import the sprite sheet into Unity and follow these steps:

- Select the sprite sheet
- Open `Sprite Editor`
- Slice the image into equal parts

After slicing, right click the sprite sheet and select:

`Create -> TextMeshPro -> Sprite Asset`

Do this for every platform you want to support. For example:

- Keyboard
- Xbox
- PlayStation

After creating all TMP Sprite Assets, right click anywhere suitable in the Project window and create:

`Create -> Input Prompt Sprite Library`

This is the ScriptableObject included with this package. Inside the `Input Prompt Sprite Library`, there are separate fields for each platform. Assign your generated TMP Sprite Assets to the Keyboard, Xbox, and PlayStation fields.

## Using It On Text

To use the package, add the `SetTextToBox` script to a GameObject that already has a TextMeshPro component. Then fill in the fields in the Inspector. Inside your text, write the keyword you want to replace.
For example:

`BUTTONPROMPT`

That’s all.

The package will generate the correct sprite tag based on the active input device and update the TextMeshPro text automatically.
