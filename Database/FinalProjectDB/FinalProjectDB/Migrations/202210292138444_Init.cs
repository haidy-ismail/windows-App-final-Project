namespace FinalProjectDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.البضاعه",
                c => new
                    {
                        رقم_الصنف = c.Int(nullable: false, identity: true),
                        اسم_الصنف = c.String(),
                        سعر_البيع = c.Double(nullable: false),
                        اجمالي_الكميه = c.Int(nullable: false),
                        سعر_الشراء = c.Double(nullable: false),
                        الوصف = c.String(),
                        الفواتير_رقم_الفاتوره = c.Int(),
                        بضاعه_رقم_الصنف = c.Int(),
                        بيع_رقم_الصنف = c.Int(),
                        شراء_رقم_الصنف = c.Int(),
                        مرتجع_بيع_رقم_الصنف = c.Int(),
                        مرتجع_شراء_رقم_الصنف = c.Int(),
                    })
                .PrimaryKey(t => t.رقم_الصنف)
                .ForeignKey("dbo.الفواتير", t => t.الفواتير_رقم_الفاتوره)
                .ForeignKey("dbo.البضاعه", t => t.بضاعه_رقم_الصنف)
                .ForeignKey("dbo.بيع", t => t.بيع_رقم_الصنف)
                .ForeignKey("dbo.شراء", t => t.شراء_رقم_الصنف)
                .ForeignKey("dbo.مرتجع_بيع", t => t.مرتجع_بيع_رقم_الصنف)
                .ForeignKey("dbo.مرتجع_شراء", t => t.مرتجع_شراء_رقم_الصنف)
                .Index(t => t.الفواتير_رقم_الفاتوره)
                .Index(t => t.بضاعه_رقم_الصنف)
                .Index(t => t.بيع_رقم_الصنف)
                .Index(t => t.شراء_رقم_الصنف)
                .Index(t => t.مرتجع_بيع_رقم_الصنف)
                .Index(t => t.مرتجع_شراء_رقم_الصنف);
            
            CreateTable(
                "dbo.الفواتير",
                c => new
                    {
                        رقم_الفاتوره = c.Int(nullable: false, identity: true),
                        التاريخ = c.DateTime(nullable: false),
                        الحساب = c.String(),
                        طريقه_الحساب = c.String(),
                        الكميه = c.Int(nullable: false),
                        الخصم = c.Double(nullable: false),
                        النهائي = c.Double(nullable: false),
                        درج_النقديه = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.رقم_الفاتوره);
            
            CreateTable(
                "dbo.بيع",
                c => new
                    {
                        رقم_الصنف = c.Int(nullable: false, identity: true),
                        اسم_الصنف = c.String(),
                        وحده = c.String(),
                        الكميه = c.Int(nullable: false),
                        السعر = c.Double(nullable: false),
                        الاجمالي = c.Double(nullable: false),
                        النهائي = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.رقم_الصنف);
            
            CreateTable(
                "dbo.شراء",
                c => new
                    {
                        رقم_الصنف = c.Int(nullable: false, identity: true),
                        اسم_الصنف = c.String(),
                        وحده = c.String(),
                        الكميه = c.Int(nullable: false),
                        السعر = c.Double(nullable: false),
                        الاجمالي = c.Double(nullable: false),
                        ألنهائي = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.رقم_الصنف);
            
            CreateTable(
                "dbo.مرتجع_بيع",
                c => new
                    {
                        رقم_الصنف = c.Int(nullable: false, identity: true),
                        اسم_الصنف = c.String(),
                        وحده = c.String(),
                        الكميه = c.Int(nullable: false),
                        السعر = c.Double(nullable: false),
                        الاجمالي = c.Double(nullable: false),
                        ألنهائي = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.رقم_الصنف);
            
            CreateTable(
                "dbo.مرتجع_شراء",
                c => new
                    {
                        رقم_الصنف = c.Int(nullable: false, identity: true),
                        اسم_الصنف = c.String(),
                        وحده = c.String(),
                        الكميه = c.Int(nullable: false),
                        السعر = c.Double(nullable: false),
                        الاجمالي = c.Double(nullable: false),
                        النهائي = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.رقم_الصنف);
            
            CreateTable(
                "dbo.الحسابات",
                c => new
                    {
                        رقم_الحساب = c.Int(nullable: false, identity: true),
                        اسم_الحساب = c.String(),
                        مدين = c.Double(nullable: false),
                        دائن = c.Double(nullable: false),
                        طبيعه_الحساب = c.String(),
                        التصنيف = c.String(),
                        كود_الحساب = c.Int(nullable: false),
                        العنوان = c.String(),
                        التليفون = c.String(),
                    })
                .PrimaryKey(t => t.رقم_الحساب);
            
            CreateTable(
                "dbo.الخزنه",
                c => new
                    {
                        رقم_المسلسل = c.Int(nullable: false, identity: true),
                        الحركه = c.String(),
                        التاريخ = c.DateTime(nullable: false),
                        وارد = c.Double(nullable: false),
                        منصرف = c.Double(nullable: false),
                        رصيد = c.Double(nullable: false),
                        الحساب = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.رقم_المسلسل);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.البضاعه", "مرتجع_شراء_رقم_الصنف", "dbo.مرتجع_شراء");
            DropForeignKey("dbo.البضاعه", "مرتجع_بيع_رقم_الصنف", "dbo.مرتجع_بيع");
            DropForeignKey("dbo.البضاعه", "شراء_رقم_الصنف", "dbo.شراء");
            DropForeignKey("dbo.البضاعه", "بيع_رقم_الصنف", "dbo.بيع");
            DropForeignKey("dbo.البضاعه", "بضاعه_رقم_الصنف", "dbo.البضاعه");
            DropForeignKey("dbo.البضاعه", "الفواتير_رقم_الفاتوره", "dbo.الفواتير");
            DropIndex("dbo.البضاعه", new[] { "مرتجع_شراء_رقم_الصنف" });
            DropIndex("dbo.البضاعه", new[] { "مرتجع_بيع_رقم_الصنف" });
            DropIndex("dbo.البضاعه", new[] { "شراء_رقم_الصنف" });
            DropIndex("dbo.البضاعه", new[] { "بيع_رقم_الصنف" });
            DropIndex("dbo.البضاعه", new[] { "بضاعه_رقم_الصنف" });
            DropIndex("dbo.البضاعه", new[] { "الفواتير_رقم_الفاتوره" });
            DropTable("dbo.الخزنه");
            DropTable("dbo.الحسابات");
            DropTable("dbo.مرتجع_شراء");
            DropTable("dbo.مرتجع_بيع");
            DropTable("dbo.شراء");
            DropTable("dbo.بيع");
            DropTable("dbo.الفواتير");
            DropTable("dbo.البضاعه");
        }
    }
}
