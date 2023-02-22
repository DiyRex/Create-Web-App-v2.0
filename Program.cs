using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateWebApp
{
    class Program
    {
        public void script(string project)
        {
            string js_dir = $"{project}/scripts";
            System.IO.Directory.CreateDirectory(js_dir);
            string js_file = $"{js_dir}/script.js";
            using (FileStream fs = new FileStream(js_file, FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    string query = $@"// Enter Your Scripts Here";
                    w.WriteLine("{0}", query);
                }
            }
        }

        public void img(string project)
        {
            string img_dir = $"{project}/img";
            System.IO.Directory.CreateDirectory(img_dir);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("\nCWA 2.0 By DiyRex :)\n");

            try
            {
                if (args[0] == "-h" || args[0] == "-H")
                {
                    Console.WriteLine("Info :\n");
                    Console.WriteLine("Web Project Building Tool\n");
                    Console.WriteLine("Help :\n");
                    Console.WriteLine("create-web-app <project name> : Create Project With Given Name");
                    Console.WriteLine("create-web-app . : Create Files within Current Dir");
                    Console.WriteLine("\nExtra Arguments\n");
                    Console.WriteLine("-b : Add bootstrap CDN");
                    Console.WriteLine("-t : Add tailwind CDN");
                    // Console.WriteLine("-j : Add jquery CDN");
                }
                else if (!(args[0] == "." || args[0] == "-b" || args[0] == "-t"))
                {
                    Console.WriteLine("Project Name is : {0}", args[0]);
                    Console.WriteLine("Building Project : {0}", args[0]);
                    System.IO.Directory.CreateDirectory(args[0]);
                    CreateFiles index = new CreateFiles();
                    index.index(args[0], args[0]);
                    index.css(args[0]);
                    index.script(args[0]);
                    index.img(args[0]);
                    
                    bool bootstrap = false;
                    bool tailwind = false;

                    foreach(string argu in args){
                        if(argu == "-b"){
                            bootstrap = true;
                        }else if(argu == "-t"){
                            tailwind = true;
                        }
                    }

                    if(bootstrap == true && tailwind != true){
                        index.index_bstrp(args[0], args[0]);
                    }else if(tailwind == true && bootstrap != true){
                        index.index_tailwind(args[0], args[0]);
                        index.tailwind_config(args[0]);
                    }else if(bootstrap == true && tailwind == true){
                        index.bootail(args[0], args[0]);
                        index.tailwind_config(args[0]);
                    }
                    Console.WriteLine("Project Built Successfully !!");
                }
                else if (args[0] == "." || args[0] == "/")
                {
                    string dir = System.Environment.CurrentDirectory;
                    string pname = new Uri(dir).Segments.Last();
                    Console.WriteLine("Project Name is : {0}", pname);
                    Console.WriteLine("Building Project : {0}", pname);
                    CreateFiles index = new CreateFiles();
                    index.index(dir, pname);
                    index.css(dir);
                    index.script(dir);
                    index.img(dir);

                    bool bootstrap = false;
                    bool tailwind = false;

                    foreach(string argu in args){
                        if(argu == "-b"){
                            bootstrap = true;
                        }else if(argu == "-t"){
                            tailwind = true;
                        }
                    }

                    if(bootstrap == true && tailwind != true){
                        index.index_bstrp(args[0], pname);
                    }else if(tailwind == true && bootstrap != true){
                        index.index_tailwind(args[0], pname);
                        index.tailwind_config(args[0]);
                    }else if(bootstrap == true && tailwind == true){
                        index.bootail(args[0], pname);
                        index.tailwind_config(args[0]);
                    }
                    Console.WriteLine("Project Built Successfully !!");
                }
            }
             
            catch (Exception)
            {
                Console.WriteLine("-h : for help");
            }
        }
    }
}