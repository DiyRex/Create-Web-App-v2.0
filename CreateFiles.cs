using System.Text;

public class CreateFiles
{
   // Create index.html

        public void index(string project, string pname)
        {
            string index_file = $"{project}/index.html";
            using (FileStream fs = new FileStream(index_file, FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    string query = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""./styles/style.css"">
    <title>{pname}</title>
</head>
<body>
    <!-- Enter Code Here -->
<script src=""./scripts/script.js""></script>
</body>
</html>";                                                   // left aligned to make content in index.html in default code block
                    w.WriteLine("{0}", query);
                }
            }
        }


        // Create index.html with bootstrap & tailwind CDN

        public void bootail(string project, string pname)
        {
            string index_file = $"{project}/index.html";
            using (FileStream fs = new FileStream(index_file, FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    string query = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <script src=""https://cdn.tailwindcss.com""></script>
    <script src=""./scripts/tailwind_config.js""></script>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""./styles/style.css"">
    <title>{pname}</title>
</head>
<body>
    <!-- Enter Code Here -->
<script src=""./scripts/script.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.6/dist/umd/popper.min.js""></script>
</body>
</html>";                                                   // left aligned to make content in index.html in default code block
                    w.WriteLine("{0}", query);
                }
            }
        }


        // Create index.html with tailwind CDN

        public void index_tailwind(string project, string pname)
        {
            string index_file = $"{project}/index.html";
            using (FileStream fs = new FileStream(index_file, FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    string query = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <script src=""https://cdn.tailwindcss.com""></script>
    <script src=""./scripts/tailwind_config.js""></script>
    <link rel=""stylesheet"" href=""./styles/style.css"">
    <title>{pname}</title>
</head>
<body>
    <!-- Enter Code Here -->
<script src=""./scripts/script.js""></script>
</body>
</html>";                                                   // left aligned to make content in index.html in default code block
                    w.WriteLine("{0}", query);
                }
            }
        }

   // Create index.html wih bootstrap added

        public void index_bstrp(string project, string pname)
        {
            string index_file = $"{project}/index.html";
            using (FileStream fs = new FileStream(index_file, FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    string query = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""./styles/style.css"">
    <title>{pname}</title>
</head>
<body>
    <!-- Enter Code Here -->
<script src=""./scripts/script.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.6/dist/umd/popper.min.js""></script>
</body>
</html>";                                                   // left aligned to make content in index.html in default code block
                    w.WriteLine("{0}", query);
                }
            }
        }

        // Create css file

        public void css(string project)
        {
            string css_dir = $"{project}/css";
            System.IO.Directory.CreateDirectory(css_dir);
            string css_file = $"{css_dir}/style.css";
            using (FileStream fs = new FileStream(css_file, FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    string query = $@"/* Enter Your Styles Here */";
                    w.WriteLine("{0}", query);
                }
            }
        }

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
        public void tailwind_config(string project)
        {
            string js_dir = $"{project}/scripts";
            System.IO.Directory.CreateDirectory(js_dir);
            string js_file = $"{js_dir}/tailwind_config.js";
            using (FileStream fs = new FileStream(js_file, FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    string query = @"tailwind.config = {
    theme: {
    extend: {
        colors: {
        clifford: '#da373d',
        }
    }
    }
}";
                    w.WriteLine("{0}", query);
                }
            }
        }

        public void img(string project)
        {
            string img_dir = $"{project}/img";
            System.IO.Directory.CreateDirectory(img_dir);
        }

}