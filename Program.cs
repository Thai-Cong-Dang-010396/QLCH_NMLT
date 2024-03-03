namespace QLCH
{
    struct Shop
    {
        Product[] product;
        Category[] category;

        public void Init()
        {
            product = new Product[5];
            for (int i = 0; i < product.Length; i++)
            {
                product[i] = new Product();
                product[i].id = "";
                product[i].nameProduct = "";
                product[i].dueDate = "";
                product[i].companyProduction = "";
                product[i].yearProduction = "";
                product[i].category = new Category();
            }
            category = new Category[5];
            for (int i = 0; i < category.Length; i++)
            {
                category[i] = new Category();
                category[i].nameCategory = "";
            }
        }

        public bool AddProduct()
        {
            int position = -1;
            for (int i = 0; i < product.Length; i++)
            {
                if (product[i].id == "")
                {
                    position = i;
                }
            }
            if (position < 0)
            {
                return false;
            }
            product[position] = Product.AddProduct();
            return true;
        }

        public bool RemoveProduct()
        {
            int position = -1;
            Console.WriteLine("+ Nhập mã mặt hàng       :   ");
            string id = Console.ReadLine();
            if (id == "")
            {
                Console.Clear();
                Console.WriteLine("--- Mã mặt hàng không hợp lệ ---");
                return false;
            }
            for (int i = 0; i < product.Length; i++)
            {
                if (product[i].id == id)
                {
                    position = i;
                }
            }
            if (position < 0)
            {
                Console.Clear();
                Console.WriteLine("--- Mã mặt hàng không tồn tại ---");
                return false;
            }
            product[position] = Product.RemoveProduct();
            return true;
        }

        public bool EditProduct()
        {
            int position = -1;
            Console.WriteLine("+ Nhập mã mặt hàng       :   ");
            string id = Console.ReadLine();
            if (id == "")
            {
                Console.Clear();
                Console.WriteLine("--- Mã mặt hàng không hợp lệ ---");
                return false;
            }
            for (int i = 0; i < product.Length; i++)
            {
                if (product[i].id == id)
                {
                    position = i;
                }
            }
            if (position < 0)
            {
                Console.Clear();
                Console.WriteLine("--- Mã mặt hàng không tồn tại ---");
                return false;
            }
            product[position] = Product.EditProduct();
            return true;
        }

        public bool FindProduct()
        {
            int position = -1;
            Console.WriteLine("+ Nhập mã mặt hàng       :   ");
            string id = Console.ReadLine();
            if (id == "")
            {
                Console.Clear();
                Console.WriteLine("--- Mã mặt hàng không hợp lệ ---");
                return false;
            }
            for (int i = 0; i < product.Length; i++)
            {
                if (product[i].id == id)
                {
                    position = i;
                }
            }
            if (position < 0)
            {
                Console.Clear();
                Console.WriteLine("--- Mã mặt hàng không tồn tại ---");
                return false;
            }
            Product.Find(product[position]);
            return true;
        }

        public bool AddCategory()
        {
            int position = -1;
            for (int i = 0; i < category.Length; i++)
            {
                if (category[i].nameCategory == "")
                {
                    position = i;
                }
            }
            if (position < 0)
            {
                return false;
            }
            category[position] = Category.AddCategory();
            return true;
        }

        public bool RemoveCategory()
        {
            int position = -1;
            Console.WriteLine("+ Nhập tên loại hàng       :   ");
            string name = Console.ReadLine();
            if (name == "")
            {
                Console.Clear();
                Console.WriteLine("--- Tên loại hàng không hợp lệ ---");
                return false;
            }
            for (int i = 0; i < category.Length; i++)
            {
                if (category[i].nameCategory == name)
                {
                    position = i;
                }
            }
            if (position < 0)
            {
                Console.Clear();
                Console.WriteLine("--- Tên loại hàng không tồn tại ---");
                return false;
            }
            category[position] = Category.RemoveCategory();
            return true;
        }

        public bool EditCategory()
        {
            int position = -1;
            Console.WriteLine("+ Nhập tên loại hàng       :   ");
            string name = Console.ReadLine();
            if (name == "")
            {
                Console.Clear();
                Console.WriteLine("--- Tên loại hàng không hợp lệ ---");
                return false;
            }
            for (int i = 0; i < category.Length; i++)
            {
                if (category[i].nameCategory == name)
                {
                    position = i;
                }
            }
            if (position < 0)
            {
                Console.Clear();
                Console.WriteLine("--- Tên loại hàng không tồn tại ---");
                return false;
            }
            category[position] = Category.EditCategory();
            return true;
        }

        public bool FindCategory()
        {
            int position = -1;
            Console.WriteLine("+ Nhập tên loại hàng       :   ");
            string name = Console.ReadLine();
            if (name == "")
            {
                Console.Clear();
                Console.WriteLine("--- Tên loại hàng không hợp lệ ---");
                return false;
            }
            for (int i = 0; i < category.Length; i++)
            {
                if (category[i].nameCategory == name)
                {
                    position = i;
                }
            }
            if (position < 0)
            {
                Console.Clear();
                Console.WriteLine("--- Tên loại hàng không tồn tại ---");
                return false;
            }
            Category.Find(category[position]);
            return true;
        }
    }
    struct Product
    {
        public string id;
        public string nameProduct;
        public string dueDate;
        public string companyProduction;
        public string yearProduction;
        public Category category;

        public void Input()
        {
            Console.WriteLine("+ Nhập mã mặt hàng       :   ");
            id = Console.ReadLine();
            Console.WriteLine("+ Nhập tên hàng          :   ");
            nameProduct = Console.ReadLine();
            Console.WriteLine("+ Nhập hạn dùng          :   ");
            dueDate = Console.ReadLine();
            Console.WriteLine("+ Nhập công ty sản xuất  :   ");
            companyProduction = Console.ReadLine();
            Console.WriteLine("+ Nhập năm sản xuất      :   ");
            yearProduction = Console.ReadLine();
            Category inputCategory = new Category();
            inputCategory.Input();
            category = inputCategory;
        }

        public static Product AddProduct()
        {
            Product newProduct = new Product();
            newProduct.Input();
            return newProduct;
        }

        public static Product RemoveProduct()
        {
            Product removeProduct = new Product();
            removeProduct = new Product();
            removeProduct.id = "";
            removeProduct.nameProduct = "";
            removeProduct.dueDate = "";
            removeProduct.companyProduction = "";
            removeProduct.yearProduction = "";
            removeProduct.category = new Category();
            return removeProduct;
        }

        public static Product EditProduct()
        {
            Console.Clear();
            Product newProduct = new Product();
            newProduct.Input();
            return newProduct;
        }

        public static void Find(Product item)
        {
            Console.Clear();
            Console.WriteLine($"Mã mặt hàng       : {item.id}");
            Console.WriteLine($"Tên hàng          : {item.nameProduct}");
            Console.WriteLine($"Hạn dùng          : {item.dueDate}");
            Console.WriteLine($"Công ty sản xuất  : {item.companyProduction}");
            Console.WriteLine($"Năm sản xuất      : {item.yearProduction}");
            Console.WriteLine($"Loại hàng         : {item.category.nameCategory}");
        }
    }
    struct Category
    {
        public string nameCategory;

        public void Input()
        {
            Console.WriteLine("+ Nhập loại hàng         :   ");
            nameCategory = Console.ReadLine();
        }

        public static Category AddCategory()
        {
            Category newCategory = new Category();
            newCategory.Input();
            return newCategory;
        }

        public static Category RemoveCategory()
        {
            Category removeCategory = new Category();
            removeCategory.nameCategory = "";
            return removeCategory;
        }

        public static Category EditCategory()
        {
            Console.Clear();
            Category newCategory = new Category();
            newCategory.Input();
            return newCategory;
        }

        public static void Find(Category item)
        {
            Console.Clear();
            Console.WriteLine($"Tên loại hàng       : {item.nameCategory}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Shop cuahang = new Shop();
            cuahang.Init();
            do
            {
                Console.Clear();
                Console.WriteLine("--- Phần mềm quản lí cửa hàng ---");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Thêm mặt hàng");
                Console.WriteLine("2. Xóa mặt hàng");
                Console.WriteLine("3. Sửa mặt hàng");
                Console.WriteLine("4. Tìm kiếm mặt hàng");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("5. Thêm loại hàng");
                Console.WriteLine("6. Xóa loại hàng");
                Console.WriteLine("7. Sửa loại hàng");
                Console.WriteLine("8. Tìm kiếm loại hàng");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("9. Thoát");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Chức năng:                       ");
                string inputString = Console.ReadLine();
                int chucnang = -1;
                if (Int32.TryParse(inputString, out int numValue))
                {
                    chucnang = numValue;
                }
                switch (chucnang)
                {
                    case 1:
                        Console.WriteLine("--------- Thêm mặt hàng ---------");
                        Console.WriteLine("---------------------------------");
                        if (cuahang.AddProduct())
                            Console.WriteLine("--- Thêm mặt hàng thành công ---");
                        else
                            Console.WriteLine("--- Không thành công. Cửa hàng đầy ---");
                        break;
                    case 2:
                        Console.WriteLine("--------- Xóa mặt hàng ----------");
                        Console.WriteLine("---------------------------------");
                        if (cuahang.RemoveProduct())
                            Console.WriteLine("--- Xóa mặt hàng thành công ---");
                        else
                            Console.WriteLine("--- Xóa mặt hàng không thành công ---");
                        break;
                    case 3:
                        Console.WriteLine("--------- Sửa mặt hàng ----------");
                        Console.WriteLine("---------------------------------");
                        if (cuahang.EditProduct())
                            Console.WriteLine("--- Sửa mặt hàng thành công ---");
                        else
                            Console.WriteLine("--- Sửa mặt hàng không thành công ---");
                        break;
                    case 4:
                        Console.WriteLine("-------- Tìm kiếm mặt hàng ------");
                        Console.WriteLine("---------------------------------");
                        if (cuahang.FindProduct())
                            Console.WriteLine("--- Tìm kiếm mặt hàng thành công ---");
                        else
                            Console.WriteLine("--- Tìm kiếm mặt hàng không thành công ---");
                        break;
                    case 5:
                        Console.WriteLine("-------- Thêm loại hàng ---------");
                        Console.WriteLine("---------------------------------");
                        if (cuahang.AddCategory())
                            Console.WriteLine("--- Thêm loại hàng thành công ---");
                        else
                            Console.WriteLine("--- Thêm loại hàng không thành công ---");
                        break;
                    case 6:
                        Console.WriteLine("--------- Xóa loại hàng ----------");
                        Console.WriteLine("----------------------------------");
                        if (cuahang.RemoveCategory())
                            Console.WriteLine("--- Xóa loại hàng thành công ---");
                        else
                            Console.WriteLine("--- Xóa loại hàng không thành công ---");
                        break;
                    case 7:
                        Console.WriteLine("--------- Sửa loại hàng ----------");
                        Console.WriteLine("----------------------------------");
                        if (cuahang.EditCategory())
                            Console.WriteLine("--- Sửa loại hàng thành công ---");
                        else
                            Console.WriteLine("--- Sửa loại hàng không thành công ---");
                        break;
                    case 8:
                        Console.WriteLine("-------- Tìm kiếm loại hàng ------");
                        Console.WriteLine("----------------------------------");
                        if (cuahang.FindCategory())
                            Console.WriteLine("--- Tìm kiếm loại hàng thành công ---");
                        else
                            Console.WriteLine("--- Tìm kiếm loại hàng không thành công ---");
                        break;
                    case 9:
                        return;
                    default:
                        Console.WriteLine("-------- Không tồn tại chức năng ------");
                        break;
                }
                Console.WriteLine("Gõ Enter để tiếp tục...");
                Console.ReadLine();
            } while (true);
        }
    }
}