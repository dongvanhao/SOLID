Các Quy tắc SOLID 
SRP: order chỉ quản lý đơn hàng, kitchen chỉ nấu ăn
OCP: muốn thêm món mới? chỉ cần tạo class mới kế thừa IFood
LSP: Salad không có cook(), nên không bị ép phải nấu
ISP: Tách IFood(thông tin món ăn) và ICookable(chế biến)
DIP: Kitchen chỉ phụ thuộc vào interface ICookable, không phụ thuộc class cụ thể 
