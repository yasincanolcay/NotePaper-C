using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePaper
{
    class Languages
    {
        public string[] weatherCityList = {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce",
        };
        public string[] addNotesLanguage = { 
            "New Note",
            "Новая заметка",
            "새 메모",
            "新筆記",
            "Yeni Not",
            "Yeni Qeyd",
            "Neue Anmerkung",
            "Nouvelle note",
            "Nuova nota",
            "ملاحظة جديدة",
            "Nueva nota",
        };
        //txt dosyasından aktarım - from txt to notepaper transfer
        public string[] getTxtFiles = {
            "Transfer from File",
            "Передача из файла",
            "파일에서 전송",
            "從文件傳輸",
            "Dosyadan Aktarın",
            "Fayldan köçürün",
            "Aus Datei übertragen",
            "Transférer à partir du fichier",
            "Trasferimento da file",
            "نقل من ملف",
            "Transferir desde archivo",
        };
        public string[] addNoteHeaderTextLanguage = {
            "Title...",
            "Заголовок...",
            "제목...",
            "標題...",
            "Başlık...",
            "Başlıq...",
            "Titel...",
            "Titre...",
            "Titolo...",
            "عنوان...",
            "Título...",
        };
        public string[] addNoteTextLanguage = {
            "Your note...",
            "Ваша заметка...",
            "당신의 메모...",
            "你的筆記...",
            "Notunuz...",
            "Sizin qeydiniz...",
            "Ihre Anmerkung...",
            "Votre remarque...",
            "La tua nota...",
            "ملاحظتك ...",
            "Tu nota..."
        };
        public string[] deleteNoteWarningHeader = {
            "Do you want to delete the note?",
            "Удалить заметку?",
            "메모를 삭제하시겠습니까?",
            "你想刪除筆記嗎？",
            "Notu Silmek İstiyor musunuz?",
            "Qeydi silmək istəyirsiniz?",
            "Möchten Sie die Notiz löschen?",
            "Voulez-vous supprimer la note ?",
            "Vuoi eliminare la nota?",
            "هل تريد حذف الملاحظة؟",
            "¿Quieres borrar la nota?",
        };
        public string[] deleteNoteMessage = {
            "This Note Will Be Permanently Deleted!",
            "Эта заметка будет удалена навсегда!",
            "이 메모는 영구적으로 삭제됩니다!",
            "此筆記將被永久刪除！",
            "Bu Not Kalıcı Olarak Silinecek!",
            "Bu qeyd həmişəlik silinəcək!",
            "Diese Notiz wird dauerhaft gelöscht!",
            "Cette note sera définitivement supprimée !",
            "Questa nota verrà eliminata definitivamente!",
            "سيتم حذف هذه الملاحظة نهائيًا!",
            "¡Esta nota se eliminará de forma permanente!",
        };
        //english
        //rusça
        //korece
        //çince
        //türkçe
        //azerice
        //almanca
        //fransızca
        //italyanca
        //arapca
        //ispanyolca
        public string[] settings = {
            "SETTINGS",
            "НАСТРОЙКИ",
            "설정",
            "設置",
            "AYARLAR",
            "AYARLAR",
            "DIE EINSTELLUNGEN",
            "RÉGLAGES",
            "IMPOSTAZIONI",
            "الإعدادات",
            "AJUSTES",
        };
        public string[] RunatStartup = {
            "Run at Startup",
            "Запустить при запуске",
            "시작 시 실행",
            "在啟動時運行",
            "Başlangıçta Çalıştır",
            "Başlanğıcda işə salın",
            "Beim Start ausführen",
            "Exécuter au démarrage",
            "Eseguire all'avvio",
            "تشغيل عند بدء التشغيل",
            "Ejecutar en el arranque",
        };
        public string[] RunatStartupDetail = {
            "NotePaper opens when computer is turned on",
            "NotePaper открывается при включении компьютера",
            "NotePaper 컴퓨터가 켜져 있을 때 열립니다",
            "NotePaper 電腦開機時亮起",
            "Bilgisayar açıldığında NotePaper açılır",
            "NotePaper kompüter işə salındıqda açılır",
            "NotePaper wird geöffnet, wenn der Computer eingeschaltet wird",
            "NotePaper s'ouvre lorsque l'ordinateur est allumé",
            "NotePaper si apre all'accensione del computer",
            "NotePaper يتم تشغيله عند تشغيل الكمبيوتر",
            "NotePaper se abre cuando la computadora está encendida",
        };
        public string[] NightModeatStartup = {
            "Night Mode at Startup",
            "Ночной режим при запуске",
            "시작 시 야간 모드",
            "啟動時的夜間模式",
            "Başlangıçta Gece Modu",
            "Başlanğıcda Gecə rejimi",
            "Nachtmodus beim Start",
            "Mode nuit au démarrage",
            "Modalità notturna all'avvio",
            "الوضع الليلي عند بدء التشغيل",
            "Modo nocturno al inicio",
        };
        public string[] NightModeatStartupDetail = {
            "Night mode is activated every time NotePaper is opened.",
            "Ночной режим активируется каждый раз при открытии NotePaper.",
            "NotePaper를 열 때마다 야간 모드가 활성화됩니다.",
            "每次打開 NotePaper 時都會激活夜間模式。",
            "NotePaper her açıldığında gece modu aktif olur.",
            "NotePaper hər dəfə açılanda gecə rejimi aktivləşdirilir.",
            "Der Nachtmodus wird jedes Mal aktiviert, wenn NotePaper geöffnet wird.",
            "Le mode nuit est activé chaque fois que NotePaper est ouvert.",
            "La modalità notte viene attivata ogni volta che si apre NotePaper.",
            "يتم تنشيط الوضع الليلي في كل مرة يتم فيها فتح NotePaper.",
            "El modo nocturno se activa cada vez que se abre NotePaper.",
        };
        public string[] AutoNightMode = {
            "Auto Night Mode",
            "Автоматический ночной режим",
            "자동 야간 모드",
            "自動夜間模式",
            "Otomatik Gece Modu",
            "Avtomatik gecə rejimi",
            "Automatischer Nachtmodus",
            "Mode nuit automatique",
            "Modalità notturna automatica",
            "الوضع الليلي التلقائي",
            "Modo nocturno automático",
        };
        public string[] AutoNightModeDetail = {
            "Adjusted to your local time",
            "Адаптировано к вашему местному времени",
            "현지 시간으로 조정됨",
            "已調整為您的當地時間",
            "Yerel saatinize göre ayarlanır",
            "Yerli vaxtınıza uyğunlaşdırılıb",
            "Angepasst an Ihre Ortszeit",
            "Ajusté à votre heure locale",
            "Adeguato all'ora locale",
            "تم تعديلها حسب توقيتك المحلي",
            "Ajustado a tu hora local",
        };
        public string[] AutoSave = {
            "Auto Save",
            "Автосохранение",
            "자동 저장",
            "自動保存",
            "Otomatik Kaydet",
            "Avtomatik Saxla",
            "Automatisch speichern",
            "Sauvegarde automatique",
            "Salvataggio automatico",
            "حفظ تلقائي",
            "Guardado automático",
        };
        public string[] AutoSaveDetail = {
            "Recording automatically while taking notes",
            "Автоматическая запись во время создания заметок",
            "메모하는 동안 자동으로 녹음",
            "記筆記時自動錄音",
            "Not alırken otomatik olarak kayıt yapılır",
            "Qeydlər apararkən avtomatik qeyd",
            "Automatisches Aufzeichnen während des Notierens",
            "Enregistrement automatique lors de la prise de notes",
            "Registrazione automatica mentre si prendono appunti",
            "التسجيل تلقائيًا أثناء تدوين الملاحظات",
            "Grabación automática mientras toma notas",
        };
        public string[] Weatherforecast = {
            "Weather forecast",
            "Прогноз погоды",
            "일기 예보",
            "天氣預報",
            "Hava Durumu",
            "Hava proqnozu",
            "Wettervorhersage",
            "Prévisions météorologiques",
            "Previsioni del tempo",
            "حالة الطقس",
            "Pronóstico del tiempo",
        };
        public string[] WeatherforecastDetail = {
            "NotePaper shows the current weather",
            "NotePaper показывает текущую погоду",
            "NotePaper는 현재 날씨를 보여줍니다",
            "NotePaper 顯示當前天氣",
            "NotePaper güncel hava durumunu gösterir",
            "NotePaper cari havanı göstərir",
            "NotePaper zeigt das aktuelle Wetter",
            "NotePaper montre la météo actuelle",
            "NotePaper mostra il tempo attuale",
            "ملاحظة: يظهر الورق الطقس الحالي",
            "NotePaper muestra el clima actual",
        };
        public string[] WeatherCity = {
            "Weather City",
            "Погода Город",
            "날씨 도시",
            "天氣城",
            "Hava Durumu Şehri",
            "Hava Şəhəri",
            "Wetter Stadt",
            "Météo Ville",
            "Città del tempo",
            "مدينة الطقس",
            "Ciudad del tiempo",
        };
        public string[] WeatherCityDetail = {
            "Choose your city",
            "Выберите свой город",
            "도시를 선택하세요",
            "選擇你的城市",
            "Şehrinizi seçin",
            "Şəhərinizi seçin",
            "Wählen Sie Ihre Stadt",
            "Choisissez votre ville",
            "Choisissez votre ville",
            "اختر مدينتك",
            "Elige tu ciudad",
        };
        public string[] Languageoptions = {
            "Language options",
            "Варианты языка",
            "언어 옵션",
            "語言選項",
            "Dil Seçenekleri",
            "Dil seçimləri",
            "Sprachoptionen",
            "Options de langue",
            "Opzioni di lingua",
            "خيارات اللغة",
            "Opciones de lenguaje",
        };
        public string[] LanguageoptionsDetail = {
            "Select the language of a country",
            "Выберите язык страны",
            "국가의 언어를 선택하십시오",
            "選擇一個國家的語言",
            "Bir ülkenin dilini seçin",
            "Ölkənin dilini seçin",
            "Wählen Sie die Sprache eines Landes aus",
            "Sélectionnez la langue d'un pays",
            "Seleziona la lingua di un paese",
            "حدد لغة البلد",
            "Seleccione el idioma de un país",
        };
        public string[] DeleteNotes = {
            "Delete Notes",
            "Удалить заметки",
            "메모 삭제",
            "刪除筆記",
            "Notları Sil",
            "Qeydləri silin",
            "Notizen löschen",
            "Supprimer les notes",
            "Elimina note",
            "حذف الملاحظات",
            "Eliminar notas",
        };
        public string[] DeleteNotesDetail = {
            "This action permanently deletes all your notes",
            "Это действие безвозвратно удаляет все ваши заметки.",
            "이 작업은 모든 메모를 영구적으로 삭제합니다.",
            "此操作會永久刪除您的所有筆記",
            "Bu işlem kalıcı olarak tüm notlarınızı siler",
            "Bu əməliyyat bütün qeydlərinizi həmişəlik silir",
            "Diese Aktion löscht dauerhaft alle Ihre Notizen",
            "Cette action supprime définitivement toutes vos notes",
            "Questa azione elimina definitivamente tutte le tue note",
            "هذا الإجراء يحذف جميع ملاحظاتك بشكل دائم",
            "Esta acción elimina permanentemente todas tus notas."
        };
        public string[] DeleteFavorites = {
            "Delete Favorites",
            "Удалить избранное",
            "즐겨찾기 삭제",
            "刪除收藏夾",
            "Favorileri Sil",
            "Sevimliləri Silin",
            "Favoriten löschen",
            "Supprimer les favoris",
            "Elimina Preferiti",
            "حذف المفضلة",
            "Eliminar favoritos",
        };
        public string[] DeleteFavoritesDetail = {
            "This action permanently deletes all your favorite notes",
            "Это действие безвозвратно удаляет все ваши любимые заметки.",
            "이 작업은 즐겨찾는 모든 메모를 영구적으로 삭제합니다.",
            "此操作將永久刪除您喜歡的所有筆記",
            "Bu işlem kalıcı olarak tüm favori notlarınızı siler",
            "Bu əməliyyat bütün sevimli qeydlərinizi həmişəlik silir",
            "Diese Aktion löscht dauerhaft alle Ihre Lieblingsnotizen",
            "Cette action supprime définitivement toutes vos notes préférées",
            "Questa azione elimina definitivamente tutte le tue note preferite",
            "يؤدي هذا الإجراء إلى حذف جميع ملاحظاتك المفضلة بشكل دائم",
            "Esta acción elimina permanentemente todas tus notas favoritas"
        };
        public string[] Reset = {
            "Reset",
            "Перезагрузить",
            "초기화",
            "重置",
            "Sıfırla",
            "Sıfırlayın",
            "Zurücksetzen",
            "Réinitialiser",
            "Ripristina",
            "إعادة ضبط",
            "Reiniciar",
        };
        public string[] ResetDetail = {
            "This action does not delete any notes, resets the settings",
            "Это действие не удаляет никаких заметок, сбрасывает настройки",
            "이 작업은 메모를 삭제하지 않으며 설정을 재설정합니다.",
            "此操作不會刪除任何筆記，會重置設置",
            "Bu işlem hiçbir notu silmez, ayarları sıfırlar",
            "Bu hərəkət heç bir qeydi silmir, parametrləri sıfırlayır",
            "Diese Aktion löscht keine Notizen, setzt die Einstellungen zurück",
            "Cette action ne supprime aucune note, réinitialise les paramètres",
            "Questa azione non elimina le note, ripristina le impostazioni",
            "هذا الإجراء لا يحذف أي ملاحظات ، ويعيد ضبط الإعدادات",
            "Esta acción no elimina ninguna nota, restablece la configuración",
        };
        public string[] ApplyNow = {
            "Apply Now",
            "Применить сейчас",
            "지금 신청",
            "現在申請",
            "Şimdi Uygula",
            "İndi müraciət et",
            "Jetzt bewerben",
            "Appliquer maintenant",
            "Applica ora",
            "قدم الآن",
            "Aplica ya",
        };
        public string[] ApplyNowDetail = {
            "Applies all settings without rebooting",
            "Применяет все настройки без перезагрузки",
            "재부팅 없이 모든 설정 적용",
            "無需重新啟動即可應用所有設置",
            "Yeniden başlatma gerekmeden, ayarların tümünü uygular",
            "Yenidən yükləmədən bütün parametrləri tətbiq edir",
            "Wendet alle Einstellungen ohne Neustart an",
            "Applique tous les paramètres sans redémarrage",
            "Applica tutte le impostazioni senza riavviare",
            "يطبق جميع الإعدادات دون إعادة التشغيل",
            "Aplica todas las configuraciones sin reiniciar",
        };
        public string[] ApplyNowWarning = {
            "Goes to login page",
            "Переходит на страницу входа",
            "로그인 페이지로 이동",
            "進入登錄頁面",
            "Giriş sayfasına gider",
            "Giriş səhifəsinə keçir",
            "Geht zur Anmeldeseite",
            "Va à la page de connexion",
            "Va alla pagina di accesso",
            "يذهب إلى صفحة تسجيل الدخول",
            "Va a la página de inicio de sesión"
        };
        public string[] Clean = {
            "Clean",
            "Чистый",
            "깨끗한",
            "乾淨的",
            "Temizle",
            "Təmiz",
            "Sauber",
            "Nettoyer",
            "Pulire",
            "ينظف",
            "Limpio",
        };
        public string[] Apply = {
            "Apply",
            "Подать заявление",
            "적용하다",
            "申請",
            "Uygula",
            "Müraciət edin",
            "Sich bewerben",
            "Appliquer",
            "Applicare",
            "يتقدم",
            "Aplicar",
        };
        public string[] Help = {
            "Help",
            "Помощь",
            "돕다",
            "幫助",
            "Yardım",
            "Kömək edin",
            "Hilfe",
            "Aider",
            "Aiuto",
            "مساعدة",
            "Ayuda",
        };
        public string[] Feedback = {
            "Feedback",
            "Обратная связь",
            "피드백",
            "反饋",
            "Geri Bildirim",
            "Əlaqə",
            "Feedback",
            "Retour d'information",
            "Feedback",
            "استجابة",
            "Retroalimentación",
        };
        public string[] About = {
            "About",
            "О",
            "에 대한",
            "關於",
            "Hakkında",
            "Haqqında",
            "Um",
            "À propos de",
            "Di",
            "حول",
            "Sobre",
        };
        public string[] Backup = {
            "Backup?",
            "Резервное копирование?",
            "지원?",
            "備份？",
            "Yedekleme?",
            "Yedəklənsin?",
            "Sicherung?",
            "Sauvegarde?",
            "Backup?",
            "دعم؟",
            "¿Respaldo?",
        };
        public string[] Donation = {
            "Donation",
            "Пожертвование",
            "기부",
            "捐款",
            "Bağış",
            "İanə",
            "Spende",
            "Don",
            "Donazione",
            "هبة",
            "Donación",
        };
        public string[] Search = {
            "Search",
            "Поиск",
            "검색",
            "搜索",
            "Ara",
            "Axtar",
            "Suche",
            "Chercher",
            "Ricerca",
            "اتصلي",
            "Búsqueda"
        };
        public string[] SearchTitle = {
            "Search Title...",
            "Название поиска...",
            "제목 검색...",
            "搜索標題...",
            "Başlık Ara...",
            "Başlıq axtar...",
            "Titel suchen...",
            "Titre de recherche...",
            "Cerca titolo...",
            "عنوان البحث ...",
            "Buscar título...",
        };
        public string[] categories = {
            "categories",
            "категории",
            "카테고리",
            "類別",
            "Kategoriler",
            "Kateqoriyalar",
            "Kategorien",
            "catégories",
            "categorie",
            "التصنيفات",
            "categorías",
        };
        public string[] Thumbnail = {
            "Thumbnail",
            "Миниатюра",
            "썸네일",
            "縮略圖",
            "Küçük Resim",
            "Miniatür",
            "Miniaturansicht",
            "Vignette",
            "Miniatura",
            "ظفري",
            "Miniatura",
        };
        public string[] Media = {
            "Media",
            "СМИ",
            "미디어",
            "媒體",
            "Medya",
            "Media",
            "Medien",
            "Médias",
            "Media",
            "وسائل الإعلام",
            "Medios de comunicación",
        };
        public string[] BackgroundColor = {
            "Background Color",
            "Фоновый цвет",
            "배경색",
            "背景顏色",
            "Arkaplan Rengi",
            "Fon rəngi",
            "Hintergrundfarbe",
            "Couleur de l'arrière plan",
            "Colore di sfondo",
            "لون الخلفية",
            "Color de fondo",
        };
        public string[] Open = {
            "Open",
            "Открытым",
            "열려 있는",
            "打開",
            "Aç",
            "Açıq",
            "Offen",
            "Ouvert",
            "Aprire",
            "فتح",
            "Abierto"
        };
        public string[] Back = {
            "Back",
            "Назад",
            "뒤",
            "後退",
            "Geri",
            "Geri",
            "Der Rücken",
            "Retour",
            "Di ritorno",
            "خلف",
            "atrás"
        };
        public string[] Clone = {
            "Clone",
            "Клон",
            "클론",
            "克隆",
            "Çogalt",
            "Klon",
            "Klon",
            "Cloner",
            "Clone",
            "استنساخ",
            "Clon",
        };
        public string[] DeleteThumbnail = {
            "Delete Thumbnail",
            "Удалить миниатюру",
            "썸네일 삭제",
            "刪除縮略圖",
            "Küçük Resmi Sil",
            "Miniatürü silin",
            "Miniaturbild löschen",
            "Supprimer la miniature",
            "Elimina miniatura",
            "حذف الصورة المصغرة",
            "Eliminar miniatura",
        };
        public string[] DefaultColor = {
            "Default Color",
            "Цвет по умолчанию",
            "기본 색상",
            "默認顏色",
            "Varsayılan Renk",
            "Defolt Rəng",
            "Standardfarbe",
            "Couleur par défaut",
            "Colore predefinito",
            "اللون الافتراضي",
            "Color predeterminado",
        };
        public string[] VideoFiles = {
            "Video Files",
            "Видео файлы",
            "비디오 파일",
            "視頻文件",
            "Video Dosyaları",
            "Video faylları",
            "Videodateien",
            "Fichiers vidéo",
            "File video",
            "ملفات الفيديو",
            "Archivos de video"
        };
        public string[] SelectVideos = {
            "Select Videos",
            "Выберите видео",
            "동영상 선택",
            "選擇視頻",
            "Videoları Seçin",
            "Videoları seçin",
            "Wählen Sie Videos aus",
            "Sélectionnez des vidéos",
            "Seleziona Video",
            "حدد مقاطع الفيديو",
            "Seleccionar vídeos"
        };
        public string[] AudioFiles = {
            "Audio Files",
            "Аудио файлы",
            "오디오 파일",
            "音頻文件",
            "Ses Dosyaları",
            "Audio faylları",
            "Audiodateien",
            "Fichiers audio",
            "File audio",
            "ملفات صوتية",
            "Archivos de sonido"
        };
        public string[] ChooseAudioFiles = {
            "Choose Audio Files",
            "Выберите аудиофайлы",
            "오디오 파일 선택",
            "選擇音頻文件",
            "Ses Dosyaları Seçin",
            "Audio Faylları seçin",
            "Wählen Sie Audiodateien",
            "Choisissez les fichiers audio",
            "Scegli File audio",
            "اختر ملفات الصوت",
            "Elija archivos de audio"
        };
        public string[] Imagefiles = {
            "Image files",
            "Файлы изображений",
            "이미지 파일",
            "圖像文件",
            "Resim Dosyaları",
            "Şəkil faylları",
            "Bilddateien",
            "Fichiers images",
            "File di immagine",
            "ملفات الصور",
            "Archivos de imagen",
        };
        public string[] SelectPictures = {
            "Select Pictures",
            "Выберите изображения",
            "사진 선택",
            "選擇圖片",
            "Resimleri Seçin",
            "Şəkillər seçin",
            "Wählen Sie Bilder aus",
            "Sélectionnez les images",
            "Seleziona Immagini",
            "حدد الصور",
            "Seleccionar imágenes",
        };
        public string[] Document = {
            "Document",
            "Документ",
            "문서",
            "文檔",
            "Belgeler",
            "Sənəd",
            "Dokumentieren",
            "Document",
            "Documento",
            "وثيقة",
            "Documento"
        };
        public string[] SelectDocuments = {
            "Select Documents",
            "Выберите документы",
            "문서 선택",
            "選擇文件",
            "Belgeleri Seçin",
            "Sənədlər seçin",
            "Wählen Sie Dokumente aus",
            "Sélectionnez Documents",
            "Seleziona Documenti",
            "حدد المستندات",
            "Seleccione Documentos"
        };
        public string[] remove = {
            "Remove",
            "удалять",
            "제거하다",
            "消除",
            "Kaldır",
            "çıxarın",
            "Löschen",
            "retirer",
            "rimuovere",
            "إزالة",
            "retirar",
        };
        public string[] Pause = {
            "Pause",
            "Пауза",
            "정지시키다",
            "暫停",
            "Duraklat",
            "Fasilə",
            "Pause",
            "Pause",
            "Pausa",
            "يوقف",
            "Pausa"
        };
        public string[] Stop = {
            "Stop",
            "Останавливаться",
            "중지",
            "停止",
            "Durdur",
            "Dayan",
            "Halt",
            "Arrêt",
            "Fermare",
            "قف",
            "Deténgase"
        };
        public string[] Play = {
            "Play",
            "Играть в",
            "놀다",
            "玩",
            "Oynat",
            "Oynamaq",
            "Spielen",
            "Jouer",
            "Giocare a",
            "لعب",
            "Tocar"
        };
        public string[] FullScreen = {
            "Full Screen",
            "Полноэкранный",
            "전체 화면",
            "全屏",
            "Tam Ekran",
            "Tam Ekran",
            "Ganzer Bildschirm",
            "Plein écran",
            "A schermo intero",
            "شاشة كاملة",
            "Pantalla completa",
        };
        public string[] Delete = {
            "Delete",
            "Удалить",
            "삭제",
            "刪除",
            "Sil",
            "Sil",
            "Löschen",
            "Effacer",
            "Elimina",
            "حذف",
            "Borrar"
        };
        public string[] Cancel = {
            "Cancel",
            "Отмена",
            "취소",
            "取消",
            "İptal",
            "Ləğv et",
            "Absagen",
            "Annuler",
            "Annulla",
            "يلغي",
            "Cancelar"
        };

        
    }
}
