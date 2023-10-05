
Создано четыре сцены.
Во-первых, так не будет придирок по тз, где сказано что должно быть четыре "экрана". Во-вторых, так разработчики могут вносить изменения каждый в свою сцену без конфликтов работая на разных.

Сделал папку Source внутри папки Scripts, потому что всегда так делаю, ведь могут быть еще тесты. Здесь я тесты писать не буду, потому что так быстрее. На мои тесты можно посмотреть в примере кода из резюме.

Я не буду разделять игру на модель-отображение, хоть она и подходит для этого. Потому что быстрее не разделять. Если хочется посмотреть на то, как я разделяю, можно посмотреть мой пример кода из резюме.

Имя игрока я выделил отдельным скриптом, который будет играть здесь роль информационного эксперта и быть ответсвенным за то, как оно сохраняется и загружается.

Меню входа сделал сначала одним общим скриптом, разделю ответсвенность, если будет время.

Все подписки-отписки делаю в OnEnable/OnDisable Awake/OnDestroy или через Dispose, если файл не монобех. Это чтобы не было утечек памяти. Между первым и вторым первый предпочтительнее, потому что OnDestroy работает не всегда.

Использую статический класс с индексами сцен, чтобы не использвать магические числа. И менять, если что, в одном только месте.

Поначалу буду делать все монобехами. Так быстрее. Если будет время, можно потом сделать обычными классами, и внедрять через зенжект, например.

Соответсвенно, так как в SerializedField нельзя без сторонних пакетов вставлять интерфейсы, иногда когда было бы разделять интерфейсы, я не буду этого делать. Так быстрее.

Вообще, если при загрузке долго нет ответа, нужно сообщать пользователю об этом и спрашивать, сделать ли запрос еще раз. Здесь про такое ничего не сказано, так что я этого делать не буду. На проекте я бы предложил, конечно, так сделать.

Для запросов использую UnityWebRequest и преобразую результат из json с посомощью JsonUtility и группы классов, повотояющих структуру json-а

Насчет того, как перебросить в бой данные о противнике. То, что нарисовано в макете экрана битвы, не очено похоже на аватар, который, я загружаю. Это позволяет нам перебрасывать только имя. Это можно делать и в PlayerPrefs.
Если там было бы много чего, лучше было бы сделать dontDestroyOnLoad объект или воспользоваться контекстом проекта из zenject. Но сейчас быстрее сделать класс хранитель и класс, который доставляет данные до хранителя. И если, что потом логику в них можно изменить.

Кошелек я сделаю очень простым. Просто класс с возможностью прибавить значение. Более сложную систему игровых ресурсов можно посмотреть в моем примере кода из резюме.

Картинку врага и монетки сгенерирую с помощью нейросети

Использую цепочку классов Health-Dabagable-Damage-DamageDealer для реализации нанесения урона. Можно было бы проще, но такой вариант относительно универсальный, я его делаю по привычке, он удобен для часто встречающихся расширений в виде типа урона, брони, уклонения и  тому подобного