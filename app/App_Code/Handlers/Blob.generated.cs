namespace zLearnHub.Handlers
{


    public partial class BlobFactoryConfig : BlobFactory
    {

        public static void Initialize()
        {
            // register blob handlers
            RegisterHandler("LessonPlanTemplatesAttachment", "\"dbo\".\"LessonPlanTemplates\"", "\"Attachment\"", new string[] {
                        "\"LessonPlanTemplateID\""}, "Lesson Plan Templates Attachment", "LessonPlanTemplates", "Attachment");
            RegisterHandler("master_student_grades_gradebooks_p4PhotoUrl", "\"dbo\".\"master_student_grades_gradebooks_p4\"", "\"PhotoUrl\"", new string[0], "Historical Grades Photo Url", "HistoricalGrades", "PhotoUrl");
            RegisterHandler("master_student_grades_gradebooks_p4Logo", "\"dbo\".\"master_student_grades_gradebooks_p4\"", "\"Logo\"", new string[0], "Historical Grades Logo", "HistoricalGrades", "Logo");
            RegisterHandler("master_student_grades_gradebooks_p4_HistLogo", "\"dbo\".\"master_student_grades_gradebooks_p4_Hist\"", "\"Logo\"", new string[0], "Historical Outcomes Logo", "HistoricalOutcomes", "Logo");
            RegisterHandler("OrganisationLogo", "\"dbo\".\"Organisation\"", "\"Logo\"", new string[] {
                        "\"OrganizationID\""}, "Organisation Logo", "Organisation", "Logo");
            RegisterHandler("OrganisationEmblem", "\"dbo\".\"Organisation\"", "\"Emblem\"", new string[] {
                        "\"OrganizationID\""}, "Organisation Emblem", "Organisation", "Emblem");
            RegisterHandler("PersonPhotoUrl", "\"dbo\".\"Person\"", "\"PhotoUrl\"", new string[] {
                        "\"PersonID\""}, "Contact Photo", "Contact", "PhotoUrl");
            RegisterHandler("ProductProductImage", "\"dbo\".\"Product\"", "\"ProductImage\"", new string[] {
                        "\"ProductID\""}, "Product Product Image", "Product", "ProductImage");
            RegisterHandler("SiteContentData", "\"dbo\".\"SiteContent\"", "\"Data\"", new string[] {
                        "\"SiteContentID\""}, "Site Content Data", "SiteContent", "Data");
            RegisterHandler("vw_metric_master_student_grades_gradebooks_p4PhotoUrl", "\"dbo\".\"vw_metric_master_student_grades_gradebooks_p4\"", "\"PhotoUrl\"", new string[0], "Grades Book P4 Photo Url", "GradesBookP4", "PhotoUrl");
            RegisterHandler("vw_metric_master_student_grades_gradebooks_p4Logo", "\"dbo\".\"vw_metric_master_student_grades_gradebooks_p4\"", "\"Logo\"", new string[0], "Grades Book P4 Logo", "GradesBookP4", "Logo");
        }
    }
}
