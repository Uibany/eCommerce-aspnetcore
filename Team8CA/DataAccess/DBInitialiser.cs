﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Policy;
using System.Linq;
using System.Threading.Tasks;
using Team8CA.Models;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;

namespace Team8CA.DataAccess
{
    public class DBInitialiser
    {
        public DBInitialiser (AppDbContext db)
        {
            db.Customers.Add(new Customer("1", "admin", "password1", "Administrator"));
            db.Customers.Add(new Customer("2", "sankalp", "sankalp", "Sankalp"));
            db.Customers.Add(new Customer("3", "s", "s", "Sean"));
            db.Customers.Add(new Customer("4", "l", "l", "Lincoln"));

            db.Products.Add(new Products("Adobe Creative Cloud", "/images/creative_cloud.png", 150.00, true, "Creative Cloud is a collection of 20+ desktop and mobile apps and services for photography, design, video, web, UX and more. Now you can take your ideas to new places with Photoshop on the iPad, draw and paint with Fresco, and design for 3D and AR.", "BusinessAndOffice", "<b>Adobe Creative Cloud</b> is a set of applications and services from Adobe Inc. that gives subscribers access to a collection of software used for graphic design, video editing, web development, photography, along with a set of mobile applications and also some optional cloud services. In Creative Cloud, a monthly or annual subscription service is delivered over the Internet. <br><br> Software from Creative Cloud is downloaded from the Internet, installed directly on a local computer and used as long as the subscription remains valid.Online updates and multiple languages are included in the CC subscription. Creative Cloud was initially hosted on Amazon Web Services, but a new agreement with Microsoft has the software, beginning with the 2017 version, hosted on Microsoft Azure.<br> Adobe Creative cloud includes access all those apps: <ul><li>Photoshop</li><li>Encore</li><li>After Effects</li><li>Premiere PRO</li><li>InDesign</li><li>Flash</li><li>Flash Builder</li><li>Dreamweaver</li><li>Illustrator</li><li>Bridge</li><li>Fireworks</li><li>Audition</li><li>SpeedGrade</li><li>Prelude</li><li>LightRoom</li></ul>"));
            db.Products.Add(new Products("Microsoft Visio 2016 Professional ", "/images/visio.png", 130.00, true, "Microsoft Visio Professional 2016 is a powerful diagramming platform with a rich set of built-in stencils. It helps you simplify complex information through simple, easy-to-understand diagrams.", "BusinessAndOffice", "<b>Microsoft Visio Professional 2016</b> makes it easier than ever for individuals and teams to create and share professional, versatile diagrams that simplify complex information. It includes all of the functionality of Visio Standard 2016 as well as updated shapes, templates, and styles; enhanced support for team collaboration, including the ability for several people to work on a simple diagram at the same time; and the ability to link diagrams to data.<br><ul><li><b> Easily diagram complex info</b><br> Microsoft Visio 2016 is a powerful diagramming platform with a rich set of built-in stencils. It helps you simplify complex information through simple, easy-to-understand diagrams. Visio includes stencils for business, basic network diagrams, organization charts, basic flowcharts, and general multi-purpose diagrams.</li><br> <li><b>Create and customize diagrams</b><br> Easily find the stencil you need with built-in search right from the start screen. Create, review, and edit diagrams on Windows 8 tablets using touch, with improved support for your most-used tasks and gestures. Get a better view of how your diagram will look when printed with a new print preview.</li><br><li><b>Fast and easy to use</b><br> Replace any shape in a diagram while preserving your shape connections, shape metadata, and overall layout. Improved alignment, spacing, and sizing guides and new ways to adjust the appearance of your shapes. Duplicate and reorder diagram pages while preserving your diagram layout and metadata.</li>"));
            db.Products.Add(new Products("Microsoft Project 2019 Professional", "/images/project.png", 150.00, true, "Manage your projects from one convenient location using Microsoft Project Professional 2019. The project management software can be bused to plan projects, collaborate with others and stay up-to-date on project progress. Project Professional 2019 includes cutting edge tools that will help your whole team work better together. This user-preferred software can be used during the entire creative process, from brainstorming sessions to production to the release of the finished product.", "BusinessAndOffice", "Manage your projects from one convenient location using<b> Microsoft Project Professional 2019</b>. The project management software can be bused to plan projects, collaborate with others and stay up-to-date on project progress. Project Professional 2019 includes cutting edge tools that will help your whole team work better together. This user-preferred software can be used during the entire creative process, from brainstorming sessions to production to the release of the finished product.<br><br><b>Language:</b> English, Arabic, Bulgarian, Chinese(Simplified), Chinese(Traditional), Croatian, Czech, Danish, Dutch, Estonian, Finnish, French, German, Greek, Hebrew, Hindi, Hungarian, Indonesian, Italian, Japanese, Kazakh, Korean, Latvian, Lithuanian, Malay, Norwegian, Polish, Portuguese(Portugal), Portuguese(Brazil), Romanian, Russian, Serbian, Slovak, Slovenian, Spanish, Swedish, Thai, Turkish, Ukrainian, Vietnamese<br><br> <b>System Requirements:</b> Operating system: Windows 10"));
            db.Products.Add(new Products("Avira Antivirus (1 year)", "/images/avira.png", 59.00, true, "Avira Antivirus Pro 1 year - 1 device is a professional antivirus software aiming to provide you with a high level of protection against the most common digital threats.", "AntivirusAndSecurity", "<b>Avira Antivirus Pro </b>is a professional antivirus software aiming to provide you with a high level of protection against the most common digital threats, including malware, viruses, trojan horses and ransomware. Increase your online safety with a top-tier solution. <br><br> <ul><li><b>Cloud-Based Latest Threats Prevention</b><br> Avira Antivirus Pro is able to detect even the latest threats that were never seen before. This is thanks to the utilizing of cloud service and network communication – as soon as the newly emerged harmful code is blocked on one of the protected devices, all other devices will have their protection rules updated within minutes to be aware of the new threat.<br><br></li> <li><b> Ransomware Protection</b><br>Ransomware is especially dangerous kind of threat, as it encrypts your files, making them unreadable while offering you a decode key in exchange for money. Don’t let cybercriminals mess with your files. Avira Antivirus Pro helps you avoid money extortion attempts caused by ransomware by preventing unauthorized access to your data. </li><br> <li><b> Email Scanning </b><br>The software scans your emails to eliminate the risk coming from opening suspicious email attachments and visiting potentially harmful links. You will be warned whenever a suspicious action is detected, allowing you to dodge the attack right before it can do any harm. </li><br> <li><b> Lightweight and Fast</b><br> Avira Antivirus Pro is not only effective but also doesn’t need much of computing power to protect your device. This means the software won’t interrupt your workflow while being run in the background – you can keep working without noticing any negative impact on the computer’s performance. Focus on your own tasks and leave the dirty job to Avira Antivirus.</li><br> <li><b> Free Customer Support </b><br> Besides the antivirus software, license code grants you unlimited access to professional customer support service, ready to dispel any doubts you may have while using the program. Reach for help whenever you need, free of additional charge – contact the support via a dedicated toll-free number or email.<br></li></ul>"));
            db.Products.Add(new Products("Malwarebytes for Mac", "/images/malwarebytes.png", 59.00, true, "Malwarebytes 4 takes out malware, adware, spyware, and other threats before they can infect your machine and ruin your day. It'll keep you safe online and your Mac running like it should.", "AntivirusAndSecurity", "<b>Malwarebytes 4 </b> takes out malware, adware, spyware, and other threats before they can infect your machine and ruin your day. It'll keep you safe online and your Mac running like it should.<br><br><ul><li><b>Make your Mac stronger</b><br> Proven Malwarebytes technology crushes the growing threat of Mac malware. So you are protected and your machine keeps running silky smooth. Finally, cybersecurity smart enough for the Mac.<br><br></li> <li><b>Protects you from Mac threats</b><br>Detects and removes viruses, ransomware, and other malware in real time with advanced anti-malware technology. Catches dangerous threats automatically, so you’re protected without having to even think about it.</li><br> <li><b>Removes adware and unwanted programs</b><br>Crushes adware and potentially unwanted programs that slow your Mac. Your Mac experience will remain clean and pristine.</li></ul>"));
            db.Products.Add(new Products("Adguard for Windows", "/images/adguardpic.png", 20.00, true, "AdGuard for Windows is not just another ad blocker, it is a multipurpose tool that combines all necessary features for the best web experience. It blocks ads and dangerous websites, speeds up page loading and protects your children when they are online.", "AntivirusAndSecurity", "<b>AdGuard for Windows</b> is not just another ad blocker, it is a multipurpose tool that combines all necessary features for the best web experience. It blocks ads and dangerous websites, speeds up page loading and protects your children when they are online.<br><br> <ul><li><b>Ad blocking</b><br> AdGuard ad filter blocks all kinds of ads. Pop-ups, video ads, banners and such — they will all go away. Due to unnoticeable background filtering and cosmetic processing, all you will see is clean pages with the content you came for.<br><br> </li> <li><b>Privacy protection</b><br> AdGuard fights against all trackers and analytical systems that spy on you. The program blocks third-party cookies, can hide your IP address, and provides an abundance of other features to protect your personal data.<br><br></li> <li><b>Protect your data</b><br>  Everything on the web nowadays tries to steal your data. AdGuard has a dedicated module to prevent that from happening.<br><br>  </li> <li><b>Safe web surfing</b><br>Protection from phishing and hazardous websites and malvertising (malicious ads). AdGuard checks every page against our database for any malicious content and blocks requests from potentially dangerous ones.<br></li></ul>"));
            db.Products.Add(new Products("Adobe Photoshop Elements 2020", "/images/photoshop1.png", 120.00, true, "Adobe Photoshop Elements 2020 It’s never been easier to create incredible photos and keepsakes. Put your best photos forward with auto-generated creations and intelligent editing options. Easily organize and share your photos, and even turn your favorites into frame-worthy prints and memorable gifts.", "DesignAndIllustration", "<b>Adobe Photoshop Elements 2020</b> It’s never been easier to create incredible photos and keepsakes. Put your best photos forward with auto-generated creations and intelligent editing options. Easily organize and share your photos, and even turn your favorites into frame-worthy prints and memorable gifts.<br><br> <ul><li><b> It's never been easier to create incredible photos and keepsakes.</b><br> Put your best photos forward with auto-generated creations and intelligent editing options. Easily organize and share your photos, and even turn your favorites into frame-worthy prints and memorable gifts.<br><br></li> <li><b> Start creating today.</b><br> Beautiful photo effects, entertaining slideshows, and creative collages are ready to go upon launch. To get started, visit the home screen for inspiring ideas, help, and tutorials. Be sure to check out the new features.<br><br></li> <li><b> Effortless organization </b><br> Cut the clutter so it’s easy to find, view, and enjoy your photos.<br><br></li> <li><b> Put your creativity in easy mode</b><br> Automated editing options and step-by-step guidance make it a snap to create amazing photos.<br><br></li> <li><b> Beautiful prints and memorable gifts </b><br> Make the most of your memories by showcasing your photos in creative ways.<br><br></li> <li><b> Shareable memories </b><br> Share with friends and family just about any way you like.</li></ul>"));
            db.Products.Add(new Products("Adobe Illustrator 5", "/images/illustrator.png", 130.00, true, "Adobe Illustrator CS5 software helps you create distinctive vector artwork for any project. Take advantage of the precision and power of sophisticated drawing tools, expressive natural brushes, and a host of time-savers.", "DesignAndIllustration", "<b>Adobe Illustrator CS5</b> software helps you create distinctive vector artwork for any project. Take advantage of the precision and power of sophisticated drawing tools, expressive natural brushes, and a host of time-savers<br><br> <ul><li>Used by design professionals worldwide, Adobe Illustrator CS5 software provides precision and power with sophisticated drawing tools, expressive natural brushes, a host of time-savers, and integration with Adobe CS Live.</li><br><br> <li>Take advantage of exceptional precision and power to create distinctive vector artwork. Combine highly controllable drawing tools with expressive natural brushes and dramatic effects to make unique, striking designs.</li><br><br> <li>Speed up your workflow with innovations that encourage efficiency. Get the job done with purpose and agility using shortcuts and time-savers to take multiple ideas to multiple outputs.</li><br><br> <li>Incorporate vector artwork into essentially any project and deliver resolution-independent graphics across media. Enjoy tighter-than-ever integration with other Adobe products and go anywhere your creativity takes you.</li><br><br> <li>Enjoy easy type creation and professional control with more than 80 OpenType fonts, paragraph and character styles, paragraph composition, underlining and strikethroughs, transparent effects, and more.</li><br><br>"));
            db.Products.Add(new Products("Adobe Creative Suite 5.5", "/images/creativesuite.png", 399.00, true, "Adobe Creative Suite 5.5 delivers important advances in HTML5 and Flash authoring, enabling designers and developers to create compelling content and applications. Creative Suite 5.5 products also feature significant innovation in the areas of video production and editing. Finally, Adobe Creative Suite 5.5 delivers exciting new capabilities in the exploding area of digital publishing.", "DesignAndIllustration", "<b>Adobe Creative Suite 5.5 </b>delivers important advances in HTML5 and Flash authoring, enabling designers and developers to create compelling content and applications. Creative Suite 5.5 products also feature significant innovation in the areas of video production and editing. Finally, Adobe Creative Suite 5.5 delivers exciting new capabilities in the exploding area of digital publishing. <br><br> Focused on the latest wave of mobile devices, this release of Creative Suite gives web designers and developers a complete software solution that allows them to produce stunning HTML5 content in the browser and deliver high-impact mobile applications through sweeping advances in Flash tooling. <br><br> Over the last year Adobe and leading publishers, including Condé Nast and Martha Stewart Living Omnimedia, have worked to develop new digital publishing workflows based on Creative Suite and Adobe InDesign. Creative Suite 5.5 will enable print publishers to create beautiful interactive publications on the latest tablet platforms. <br><br> Creative Suite 5.5 Design Premium Suite builds upon Adobe’s product innovations in publishing already deployed by some of the world’s leading newspaper, magazine and business publishers to create print and stunning digital versions of their properties for the latest tablet devices. Using Adobe InDesign CS5.5, in combination with the integrated Folio Producer toolset, designers can add new levels of interactivity to their page layouts targeted at tablet devices. Adobe today also announced the immediate availability of the Professional Edition of Adobe Digital Publishing Suite, a turnkey solution that includes hosted services and viewer technology that allow publishers to cost-efficiently publish content to Android tablets, BlackBerry PlayBook and Apple iPad (see separate release). "));

            AddReviews("DataAccess/ReviewData.data", db);
            db.SaveChanges();
        }

        protected void AddReviews(string filename, AppDbContext db) 
        {
            string[] rows = File.ReadAllLines(filename);
            foreach (string row in rows) 
            {
                string[] cell = row.Split(";");
                string customerName = cell[0];
                int productID = Convert.ToInt32(cell[1]);
                int starRating = Convert.ToInt32(cell[2]);
                string reviewDetails = cell[3];
                Random r = new Random();
                int random = r.Next(1, 12);
                DateTime reviewDate = DateTime.Now.AddDays(-random).AddHours(-random).AddMinutes(+random);
                db.Reviews.Add(new Review(productID, customerName, starRating, reviewDetails, reviewDate));
            }
        }
    }
}

              