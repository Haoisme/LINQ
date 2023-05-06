namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo danh sách List<Staff> để lưu trữ nhân viên
            List<Staff> staffList = new List<Staff>();

            // Thêm 3 nhân viên vào danh sách bằng cách sử dụng LINQ
            staffList.AddRange(new Staff[]
            {
            new Manager("John Smith", 5000.0, 1000.0),
            new Technician("Jane Doe", 2000.0, 500.0),
            new Manager("James Johnson", 4500.0, 800.0)
            });

            // In thông tin của danh sách nhân viên
            Console.WriteLine("List of Staff:");
            foreach (Staff staffs in staffList)
            {
                Console.WriteLine(staffs.ToString());
            }
            // Nhập tên thuộc tính để tính lương
            Console.Write("Enter property name (Salary or Allowance or OvertimePay): ");
            string propertyName = Console.ReadLine();

            // Sử dụng LINQ để tính lương cho nhân viên
            double totalSalary = staffList.Sum(s => (double)s.GetType().GetProperty(name: propertyName).GetValue(s));

            // In tổng lương của các nhân viên
            Console.WriteLine($"Total {propertyName}: {totalSalary}");
            // Hiển thị thông tin của một nhân viên (Manager hoặc Technician)
            Console.Write("Enter staff name: ");
            string staffName = Console.ReadLine();

            // Sử dụng Stream API để tìm kiếm nhân viên có tên phù hợp
            Staff staff = staffList.Where(s => s.GetName().Equals(staffName)).FirstOrDefault();

            if (staff != null)
            {
                // Nếu tìm thấy nhân viên, hiển thị thông tin bằng phương thức toString()
                Console.WriteLine(staff.ToString());
            }
            else
            {
                // Nếu không tìm thấy nhân viên, thông báo cho người dùng
                Console.WriteLine("Staff not found.");
            }
        }
    }
}