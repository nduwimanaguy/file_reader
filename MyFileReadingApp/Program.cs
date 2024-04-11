// See https://aka.ms/new-console-template for more information



Console.WriteLine("Hello, World!");
 Console.WriteLine("Welcome to File Reader!");

            // Initialize the FileReader
            var fileReader = new FileReader();

            // Prompt the user to specify the file type
            Console.WriteLine("Enter the file type to read (text/xml/json):");
            string fileType = Console.ReadLine()?.ToLower();

            switch (fileType)
            {
                case "text":
                    Console.WriteLine("Reading a text file...");
                    fileReader.ReadTextFile("path_to_text_file.txt");
                    break;
                case "xml":
                    Console.WriteLine("Reading an XML file...");
                    fileReader.ReadXmlFile("path_to_xml_file.xml");
                    break;
                case "json":
                    Console.WriteLine("Reading a JSON file...");
                    fileReader.ReadJsonFile("path_to_json_file.json");
                    break;
                default:
                    Console.WriteLine("Unsupported file type. Please try again.");
                    break;
            }
/*
            // Ask if encryption is needed
            Console.WriteLine("Do you want to read an encrypted file? (yes/no):");
            string encryptOption = Console.ReadLine()?.ToLower();

            if (encryptOption == "yes")
            {
                fileReader.EnableEncryption();
            }

            // Ask if role-based security is needed
            Console.WriteLine("Do you want to read with role-based security? (yes/no):");
            string securityOption = Console.ReadLine()?.ToLower();

            if (securityOption == "yes")
            {
                Console.WriteLine("Enter your role:");
                string userRole = Console.ReadLine();
                fileReader.EnableRoleBasedSecurity(userRole);
            }

            Console.WriteLine("Press any key to exit...");
            */
            Console.ReadKey();