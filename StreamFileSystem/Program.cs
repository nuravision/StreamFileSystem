using System.Text;

class Program
{
    static void Main(string[] args)
    {

        //string folder = "C:\\TaskFolder";

        //if (!Directory.Exists(folder))
        //{
        //    Directory.CreateDirectory(folder);
        //    Console.WriteLine("Folder yaradildi!");
        //}
        //else
        //{
        //    Console.WriteLine("Folder adi movcuddur!");
        //}
        //Console.Write("Yaratmaq istediyiniz folder adini daxil edin:");
        //string newFolder=Console.ReadLine();    
        //Directory.CreateDirectory($"{folder}\\{newFolder}");



        //Console.Write("Axtardiginiz folderin adini daxil edin:");
        //string searchFolder = Console.ReadLine();

        //string[] subFolders = Directory.GetDirectories(folder);
        //bool check = true;
        //foreach (string subFolder in subFolders) {
        //    string name = Path.GetFileName(subFolder);
        //    if (name==searchFolder)
        //    {
        //        check = false;
        //    }
        //}
        //if (check) {
        //    Console.WriteLine("Bele bir folder yoxdur!");
        //}
        //else
        //{
        //    Console.WriteLine("Folder tapildi!");
        //}


        //Console.Write("Silmek istediyiniz folderin adini daxil edin:");
        //string deletedFolder = Console.ReadLine();
        //string[] folders = Directory.GetDirectories(folder);
        //bool check = true;
        //foreach (var item in folders)
        //{
        //    string folderName = Path.GetFileName(item);
        //    if (folderName == deletedFolder)
        //    {
        //        Directory.Delete(item, true);
        //        check = false;
        //        break;
        //    }
        //    else
        //    {
        //        check = true;
        //    }
        //}
        //if (check)
        //{
        //    Console.WriteLine("Folder tapilmadi");
        //}
        //else
        //{
        //    Console.WriteLine("Folder silindi!");
        //}





        // string folder = "C:\\TaskFolder";
        //Console.Write("Yaratmaq istediyiniz fayl adini daxil edin:");
        //string fileName=Console.ReadLine();
        //FileStream fileStream = new FileStream($"{folder}\\{fileName}.txt", FileMode.Create);

        //string[] fileNames = Directory.GetFiles(folder);
        //foreach (var item in fileNames) {
        //    Console.WriteLine(Path.GetFileName(item));
        //}


        //Console.Write("Axtardiginiz file adini daxil edin:");
        //string searchedFileName=Console.ReadLine();
        //bool check = false;
        //foreach (var item in fileNames)
        //{
        //    string fileName=Path.GetFileName(item);
        //    if (searchedFileName==fileName)
        //    {
        //        check = true;
        //        break;  
        //    }
        //    else
        //    {
        //        check = false;
        //    }
        //}
        //if (check) {
        //    Console.WriteLine("Fayl tapildi!");
        //}
        //else
        //{
        //    Console.WriteLine("Fayl tapilmadi!");
        //}








        //Console.Write("Silmek istediyiniz file adini daxil edin(txt formati ile):");
        //string deletedFileName = Console.ReadLine();
        //bool check = false;
        //foreach (var item in fileNames)
        //{
        //    string fileName = Path.GetFileName(item);
        //    if (deletedFileName == fileName)
        //    {
        //        File.Delete(item);  
        //        check = true;
        //        break;
        //    }

        //}
        //if (check)
        //{
        //    Console.WriteLine("Fayl silindi!");
        //}
        //else
        //{
        //    Console.WriteLine("Fayl tapilmadi!");
        //}







        //    string folder = "C:\\TaskFolder";

        //    Console.Write("Yaratmaq istediyiniz fayl adini daxil edin: ");
        //    string fileName = Console.ReadLine();

        //    string filePath = $"{folder}\\{fileName}.txt";

        //    if (!File.Exists(filePath))
        //    {
        //        File.Create(filePath).Close();
        //        Console.WriteLine($"Fayl '{filePath}' yaradildi.");
        //    }

        //    Console.Write("Yazmaq istediyiniz metn: ");
        //    string additionalContent = Console.ReadLine();

        //    File.AppendAllText(filePath, additionalContent + Environment.NewLine); 

        //    Console.WriteLine("Yeni metn fayla elave edildi.");




        //    Console.Write("Oxumaq istediyiniz faylin adini daxil edin: ");
        //    string fileWriterName = Console.ReadLine();

        //    if (File.Exists(filePath))
        //    {
        //        string fileContent = File.ReadAllText(filePath);
        //        Console.WriteLine("Fayldan oxunan metn:");
        //        Console.WriteLine(fileContent);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Fayl tapilmadi.");
        //    }





        //string folder = "C:\\TaskFolder";

        //Console.Write("Axtarmaq istediyiniz metni daxil edin: ");
        //string searchText = Console.ReadLine();

        //bool check = true;
        //string[] folders = Directory.GetDirectories(folder);

        //foreach (string folderItem in folders)
        //{
        //    string[] files = Directory.GetFiles(folderItem);

        //    foreach (string fileItem in files)
        //    {
        //        string fileContent = File.ReadAllText(fileItem);
        //        if (fileContent.Contains(searchText))
        //        {
        //            Console.WriteLine($" Metn tapildi: {fileItem}");
        //        }
        //    }
        //}
       


    }
}