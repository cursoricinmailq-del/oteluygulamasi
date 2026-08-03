using System.Globalization;

namespace OtelUygulamasi.Services;

public class LocalizationService
{
    private readonly Dictionary<string, Dictionary<string, string>> _resources = new()
    {
        ["tr"] = new()
        {
            ["AppTitle"] = "OtelRezervasyon",
            ["AppSubtitle"] = "Profesyonel otel yönetimi ve rezervasyon deneyimi",
            ["Home"] = "Anasayfa",
            ["Rooms"] = "Otel Odaları",
            ["Reservations"] = "Rezervasyonlar",
            ["Admin"] = "Yönetim",
            ["Analytics"] = "Analitik",
            ["About"] = "Hakkımızda",
            ["LoginRegister"] = "Giriş / Kayıt",
            ["Logout"] = "Çıkış",
            ["LoginTitle"] = "OtelRezervasyon Giriş",
            ["LoginDescription"] = "Hesabınıza güvenli şekilde giriş yapın. Giriş bilgilerinizi bizimle paylaşmayın.",
            ["UsernameLabel"] = "Kullanıcı Adı",
            ["EmailLabel"] = "E-posta",
            ["PasswordLabel"] = "Parola",
            ["LoginButton"] = "Giriş Yap",
            ["HeroDiscover"] = "Şimdi Keşfedin",
            ["RequiredFieldsError"] = "Kullanıcı adı ve e-posta alanları zorunludur.",
            ["LoginFailed"] = "Giriş başarısız oldu. Kullanıcı adı veya parola yanlış.",
            ["RegisterTitle"] = "Hesap Oluştur",
            ["RegisterDescription"] = "Yeni kullanıcı oluşturun ve hesabınıza güvenli şekilde giriş yapın.",
            ["ConfirmPasswordLabel"] = "Parola Onayı",
            ["RegisterButton"] = "Kayıt Ol",
            ["PasswordMismatchError"] = "Parola ve parola onayı birbirini tutmuyor.",
            ["UsernameExistsError"] = "Bu kullanıcı adı zaten kullanılıyor.",
            ["EmailExistsError"] = "Bu e-posta adresi zaten kayıtlı.",
            ["RegistrationFailed"] = "Kayıt sırasında bir hata oluştu. Lütfen tekrar deneyin.",
            ["RegisterLinkText"] = "Henüz hesabınız yok mu? Kayıt olun.",
            ["Welcome"] = "Lüks otel konforunu bir adım öne taşıyın",
            ["HeroSubtitle"] = "OtelRezervasyon ile özel odalar, hızlı rezervasyon ve profesyonel yönetim paneli tek noktada. Hemen giriş yaparak planınızı tamamlayın.",
            ["BookNow"] = "Rezervasyonlara Git",
            ["ViewRooms"] = "Oda Seçeneklerini Gör",
            ["FeaturesTitle"] = "OtelRezervasyon ile neler yapabilirsiniz?",
            ["FeatureRoomManagement"] = "Kolayca yeni oda ekleyin, düzenleyin ve mevcut oda bilgilerini yönetin.",
            ["FeatureBookingTracking"] = "Müşteri rezervasyonlarını hızlıca görüntüleyin ve durumlarını yönetin.",
            ["FeatureMessaging"] = "Müşteri sorularını alın, işaretleyin ve admin panelinden takip edin.",
            ["ProfessionalTitle"] = "Güvenli ve profesyonel",
            ["ProfessionalText"] = "Müşterilerinizin rezervasyon sürecini basitleştirin ve yönetim paneli ile tüm verileri kontrol edin.",
            ["StatReservations"] = "Rezervasyon",
            ["StatSatisfaction"] = "Müşteri memnuniyeti",
            ["AnalyticsTitle"] = "Yönetim Analitiği",
            ["AnalyticsSummary"] = "Yönetim için doluluk, rezervasyon ve gelir raporlarınızı tek noktada görüntüleyin.",
            ["RevenueThisMonth"] = "Bu Ayın Geliri",
            ["BookingStatus"] = "Rezervasyon Durumları",
            ["Confirmed"] = "Onaylı",
            ["Pending"] = "Beklemede",
            ["AnalyticsRevenue"] = "Toplam Gelir",
            ["AnalyticsBookings"] = "Rezervasyon Sayısı",
            ["AnalyticsOccupiedRooms"] = "Dolu Oda Sayısı",
            ["AnalyticsCancelled"] = "İptal Edilen",
            ["AnalyticsOccupancyRate"] = "Doluluk Oranı",
            ["AnalyticsMessageTags"] = "Mesaj Etiketleri",
            ["TagNone"] = "Etiketsiz",
            ["TagImportant"] = "Önemli",
            ["TagReservation"] = "Rezervasyon",
            ["TagFollowUp"] = "Takip",
            ["TagOther"] = "Diğer",
            ["AdminOnly"] = "Bu sayfayı görüntüleme yetkiniz yok. Lütfen admin hesabıyla giriş yapın.",
            ["MessageRead"] = "Mark As Read",
            ["MessageUnread"] = "Mark As Unread",
            ["Delete"] = "Sil",
            ["NoMessages"] = "Mesaj yok.",
            ["RoomOccupancy"] = "Oda Doluluk",
            ["MonthlyRevenue"] = "Aylık Gelir",
            ["MessageTag"] = "Etiket",
            ["NoTagLabel"] = "Etiketsiz"
        },
        ["en"] = new()
        {
            ["AppTitle"] = "HotelReservation",
            ["AppSubtitle"] = "Professional hotel management and booking experience",
            ["Home"] = "Home",
            ["Rooms"] = "Rooms",
            ["Reservations"] = "Reservations",
            ["Admin"] = "Admin",
            ["Analytics"] = "Analytics",
            ["About"] = "About",
            ["LoginRegister"] = "Login / Register",
            ["Logout"] = "Logout",
            ["LoginTitle"] = "HotelReservation Login",
            ["LoginDescription"] = "Sign in securely. Do not share your login information.",
            ["UsernameLabel"] = "Username",
            ["EmailLabel"] = "Email",
            ["PasswordLabel"] = "Password",
            ["LoginButton"] = "Sign In",
            ["HeroDiscover"] = "Discover now",
            ["RequiredFieldsError"] = "Username and email are required fields.",
            ["LoginFailed"] = "Login failed. Username or password is incorrect.",
            ["RegisterTitle"] = "Create Account",
            ["RegisterDescription"] = "Create a new account and sign in securely.",
            ["ConfirmPasswordLabel"] = "Confirm Password",
            ["RegisterButton"] = "Register",
            ["PasswordMismatchError"] = "Password and confirmation do not match.",
            ["UsernameExistsError"] = "That username is already taken.",
            ["EmailExistsError"] = "That email address is already registered.",
            ["RegistrationFailed"] = "Registration failed. Please try again.",
            ["RegisterLinkText"] = "Don't have an account? Register now.",
            ["Welcome"] = "Bring luxury hotel comfort to the next level",
            ["HeroSubtitle"] = "Book premium rooms swiftly and manage your hotel operations from one platform. Sign in now to continue.",
            ["BookNow"] = "Go to Reservations",
            ["ViewRooms"] = "View Rooms",
            ["FeaturesTitle"] = "What you can do with HotelReservation",
            ["FeatureRoomManagement"] = "Easily add, edit, and manage your hotel room listings.",
            ["FeatureBookingTracking"] = "Track customer bookings quickly and manage their status.",
            ["FeatureMessaging"] = "Receive customer inquiries, flag them, and manage them from the admin panel.",
            ["ProfessionalTitle"] = "Secure and professional",
            ["ProfessionalText"] = "Simplify the booking flow and control every detail from the admin dashboard.",
            ["StatReservations"] = "Reservations",
            ["StatSatisfaction"] = "Customer satisfaction",
            ["AnalyticsTitle"] = "Admin Analytics",
            ["AnalyticsSummary"] = "View occupancy, booking, and revenue reports in one place.",
            ["RevenueThisMonth"] = "Revenue This Month",
            ["BookingStatus"] = "Booking Status",
            ["Confirmed"] = "Confirmed",
            ["Pending"] = "Pending",
            ["AnalyticsRevenue"] = "Total Revenue",
            ["AnalyticsBookings"] = "Booking Count",
            ["AnalyticsOccupiedRooms"] = "Occupied Rooms",
            ["AnalyticsCancelled"] = "Cancelled",
            ["AnalyticsOccupancyRate"] = "Occupancy Rate",
            ["AnalyticsMessageTags"] = "Message Tags",
            ["TagNone"] = "No Tag",
            ["TagImportant"] = "Important",
            ["TagReservation"] = "Reservation",
            ["TagFollowUp"] = "Follow Up",
            ["TagOther"] = "Other",
            ["AdminOnly"] = "You do not have permission to view this page. Please log in with an admin account.",
            ["MessageRead"] = "Mark As Read",
            ["MessageUnread"] = "Mark As Unread",
            ["Delete"] = "Delete",
            ["NoMessages"] = "No messages.",
            ["RoomOccupancy"] = "Room Occupancy",
            ["MonthlyRevenue"] = "Monthly Revenue",
            ["MessageTag"] = "Tag",
            ["NoTagLabel"] = "No Tag"
        }
    };

    public string CurrentCulture { get; private set; } = "tr";

    public event Action? OnChange;

    public string this[string key]
    {
        get
        {
            if (_resources.TryGetValue(CurrentCulture, out var map) && map.TryGetValue(key, out var value))
            {
                return value;
            }
            return key;
        }
    }

    public void SetCulture(string culture)
    {
        if (string.IsNullOrWhiteSpace(culture))
            return;

        culture = culture.ToLowerInvariant();
        if (!_resources.ContainsKey(culture))
            return;

        CurrentCulture = culture;
        OnChange?.Invoke();
    }
}
