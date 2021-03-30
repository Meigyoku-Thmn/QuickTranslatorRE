# QuickVietPhraseMultiplicator
Công cụ này có chức năng "nhân" một file VietPhrase với một file luật nhân (nhân các dòng của file này với các dòng của file kia theo kiểu tích Đề-các) để tạo ra một file VietPharse mới.

Các bạn xem ví dụ (mình đều rút từ chương trình mà ra) để hiểu thêm chi tiết:
## Ví dụ (tên file không nhất thiết phải giống):
Cho 2 file:
### Vietphrase.txt
```
奖金=tiền thưởng
奖项=giải thưởng
```
và
### Luật nhân.txt
```
别的{0}={0} khác
```
thì chương trình này sẽ nhân 2 file trên thành một file mới là:
### Vietphrase Output.txt
```
别的奖金=tiền thưởng khác
别的奖项=giải thưởng khác
```
## Ví dụ 2:
| Vietphrase.txt | Luật nhân.txt        | Vietphrase Output.txt       |
|----------------|----------------------|-----------------------------|
| 仆人=người hầu | 那些{0}=những {0} kia | 那些仆人=những người hầu kia |
## Chú ý:
```
Chú ý 1: tên file kết quả có dạng QuickVietPhraseMultiplicator_yyyyMMddHHmmss.txt
Chú ý 2: file luật nhân có thể có nhiều dòng, mỗi luật là một dòng. Chỗ thay thế {0} có thể đặt ở bất kỳ vị trí nào.
Chú ý 3: cụm VietPhrase trùng với phần tiếng Trung của luật nhân sẽ được bỏ qua.
```
