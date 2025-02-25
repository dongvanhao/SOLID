# Các Quy tắc SOLID 
1. SRP: order chỉ quản lý đơn hàng, kitchen chỉ nấu ăn
2. OCP: muốn thêm món mới? chỉ cần tạo class mới kế thừa IFood
3. LSP: Salad không có cook(), nên không bị ép phải nấu
4. ISP: Tách IFood(thông tin món ăn) và ICookable(chế biến)
5. DIP: Kitchen chỉ phụ thuộc vào interface ICookable, không phụ thuộc class cụ thể 
