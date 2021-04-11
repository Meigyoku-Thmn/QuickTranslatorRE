# QuickTranslatorRE
Đây là mã nguồn phục chế từ phiên bản QuickTranslator 08-07-2013 của tác giả ngoctay trên diễn đàn Tàng Thư Viện. Mã nguồn không nhất thiết phải giống với bản gốc, tuy nhiên hiện tại chức năng phần mềm vẫn như cũ.

Mã nguồn sẽ dần dần được refactor cho dễ hiểu hơn.

## Các công cụ đã bị loại bỏ
- **OnlineTranslationEngine:**

Module này sử dụng WebAPI Bing Translator cũ của Microsoft, Microsoft đã dừng dịch vụ này từ lâu và thay bằng hệ thống khác.
- **QuickWebBrowser:**

Quá cũ, quá nhiều bug, hiện tại đã có các trang web "dịch" vietphrase trực tiếp từ url rồi, công cụ này coi như hết sứ mệnh.
