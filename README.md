# [Challenge][Class][ProductInventoryProject]

B1. Sau khi đọc đề bài tôi bắt đầu tạo class product với các thông tin như đề bài yêu cầu
    Tôi tạo ra 1 hàm dựng chứa tham số đầy đủ để có thể đổ dữ liệu vào một cách nhanh chóng để có thể test
    
B2. Tôi tạo ra một lớp Inventory với thuộc tính là một list các product.
    Tại đây tôi tạo ra các phương thức
      GetAllFroductList(): dùng để lấy ra danh sách các product có trong Inventory 
      GetProductById(int id): Lấy product có trong Inventory, tại đây tôi so sánh id với các id của product có trong Inventory
        bằng cách sử dụng foreach. Nếu tìm thấy tôi sẽ return ra product đó. kết thúc foreach chứng tỏ id nhập vào không có trong
        Inventory nên sẽ trả về null. 
      AddProduct(product product): hàm này dùng để thêm 1 đối tượng product vào Inventory 
      EditProduct(product product): hàm này dùng để thay đổi thông tin của product trong Inventory 
      DeleteProduct(int id): hàm này dùng để xóa product trong Inventory 
      SumProductPrice(): hàm này dùng để tính tổng giá trị các product đang có trong Inventory 
      
 B3. Tôi thực hiện test tại Program.cs
