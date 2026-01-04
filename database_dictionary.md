# TỪ ĐIỂN DỮ LIỆU (DATA DICTIONARY)

Tài liệu này mô tả chi tiết ý nghĩa của từng cột (attribute) trong các bảng cơ sở dữ liệu của dự án NextGenLMS.

---

## 1. PHÂN HỆ HỆ THỐNG (SYSTEM)

### 1.1. Departments (Khoa)
Lưu trữ thông tin các Khoa trong trường (VD: CNTT, Kinh tế).

| Tên Cột | Kiểu Dữ Liệu | Đặc Tả | Mô Tả |
| :--- | :--- | :--- | :--- |
| `Id` | `UNIQUEIDENTIFIER` | PK | Khóa chính. |
| `Name` | `NVARCHAR(MAX)` | Not Null | Tên khoa (VD: Khoa Công nghệ thông tin). |
| `Code` | `NVARCHAR(MAX)` | Not Null | Mã khoa (VD: FIT). Dùng để đặt mã sinh viên. |
| `CreatedAt` | `DATETIME2` | Not Null | Ngày tạo. |

### 1.2. Majors (Ngành học)
Các chuyên ngành thuộc một Khoa.

| Tên Cột | Kiểu Dữ Liệu | Đặc Tả | Mô Tả |
| :--- | :--- | :--- | :--- |
| `Id` | `UNIQUEIDENTIFIER` | PK | Khóa chính. |
| `Name` | `NVARCHAR(MAX)` | Not Null | Tên ngành (VD: Kỹ thuật phần mềm). |
| `DepartmentId` | `UNIQUEIDENTIFIER` | FK | Thuộc khoa nào. |

### 1.3. SystemConfigs (Cấu hình)
Lưu cấu hình động của hệ thống (Key-Value).

| Tên Cột | Kiểu Dữ Liệu | Đặc Tả | Mô Tả |
| :--- | :--- | :--- | :--- |
| `ConfigKey` | `NVARCHAR(MAX)` | Not Null | Tên cấu hình (VD: `MaxUploadSize`). |
| `ConfigValue` | `NVARCHAR(MAX)` | Not Null | Giá trị (VD: `50MB`). |

---

## 2. PHÂN HỆ NGƯỜI DÙNG (USERS)

### 2.1. AppUsers (Người dùng)
Bảng trung tâm lưu tất cả Admin, Giảng viên, Sinh viên.

| Tên Cột | Kiểu Dữ Liệu | Đặc Tả | Mô Tả |
| :--- | :--- | :--- | :--- |
| `Email` | `NVARCHAR(MAX)` | Not Null | Email đăng nhập. |
| `PasswordHash` | `NVARCHAR(MAX)` | Not Null | Mật khẩu đã mã hóa (BCrypt). |
| `FullName` | `NVARCHAR(MAX)` | Not Null | Họ và tên đầy đủ. |
| `StudentCode` | `NVARCHAR(MAX)` | Nullable | Mã SV (Chỉ dành cho sinh viên, Giảng viên field này null). |
| `AvatarUrl` | `NVARCHAR(MAX)` | Nullable | Link ảnh đại diện. |
| `RoleId` | `UNIQUEIDENTIFIER` | FK | Vai trò (Admin/Lecturer/Student). |
| `IsFirstLogin` | `BIT` | Not Null | = 1 nếu là lần đăng nhập đầu (để yêu cầu đổi mật khẩu). |

---

## 3. PHÂN HỆ KHÓA HỌC (COURSES)

### 3.1. Courses (Lớp học phần)
Một lớp học cụ thể mở trong một học kỳ.

| Tên Cột | Kiểu Dữ Liệu | Đặc Tả | Mô Tả |
| :--- | :--- | :--- | :--- |
| `CourseCode` | `NVARCHAR(MAX)` | Not Null | Mã lớp học phần (VD: NET101_FALL24). |
| `Name` | `NVARCHAR(MAX)` | Not Null | Tên môn học. |
| `SemesterId` | `UNIQUEIDENTIFIER` | FK | Học kỳ nào. |
| `LecturerId` | `UNIQUEIDENTIFIER` | FK | Giảng viên nào phụ trách. |

### 3.2. CourseStudents (Danh sách lớp)
Bảng trung gian ghi nhận sinh viên nào học lớp nào.

| Tên Cột | Kiểu Dữ Liệu | Đặc Tả | Mô Tả |
| :--- | :--- | :--- | :--- |
| `CourseId` | `UNIQUEIDENTIFIER` | FK | Lớp học. |
| `StudentId` | `UNIQUEIDENTIFIER` | FK | Sinh viên. |
| `EnrolledDate` | `DATETIME2` | Not Null | Ngày được thêm vào lớp. |

---

## 4. PHÂN HỆ NỘI DUNG (CONTENT) - TPT Strategy

### 4.1. CourseContents (Nội dung gốc)
Bảng cha chứa thông tin chung của mọi loại học liệu.

| Tên Cột | Kiểu Dữ Liệu | Đặc Tả | Mô Tả |
| :--- | :--- | :--- | :--- |
| `ChapterId` | `UNIQUEIDENTIFIER` | FK | Thuộc chương nào của khóa học. |
| `Title` | `NVARCHAR(MAX)` | Not Null | Tiêu đề bài học/bài thi. |
| `OrderIndex` | `INT` | Not Null | Thứ tự hiển thị trong chương. |
| `Type` | `INT` | Not Null | 1=Lesson, 2=Quiz, 3=Assignment. |

### 4.2. Lessons (Bài giảng)
(*) Kế thừa từ `CourseContents`.

| Tên Cột | Kiểu Dữ Liệu | Đặc Tả | Mô Tả |
| :--- | :--- | :--- | :--- |
| `Id` | `UNIQUEIDENTIFIER` | PK/FK | Trỏ về `CourseContents.Id`. |
| `FileUrl` | `NVARCHAR(MAX)` | Nullable | Link file (PDF/Video) nếu có. |
| `ContentHtml` | `NVARCHAR(MAX)` | Nullable | Nội dung bài học dạng văn bản (Rich Text). |
| `DurationSeconds`| `INT` | Not Null | Thời lượng video (để tính tiến độ). |

### 4.3. Quizzes (Bài kiểm tra)
(*) Kế thừa từ `CourseContents`.

| Tên Cột | Kiểu Dữ Liệu | Đặc Tả | Mô Tả |
| :--- | :--- | :--- | :--- |
| `Id` | `UNIQUEIDENTIFIER` | PK/FK | Trỏ về `CourseContents.Id`. |
| `DurationMinutes`| `INT` | Not Null | Thời gian làm bài (phút). |
| `OpenTime` | `DATETIME2` | Nullable | Thời điểm mở đề. |
| `CloseTime` | `DATETIME2` | Nullable | Thời điểm đóng đề. |
| `ShuffleQuestions`| `BIT` | Not Null | Có xáo trộn câu hỏi không? |
| `ShuffleAnswers` | `BIT` | Not Null | Có xáo trộn đáp án A/B/C/D không? |

### 4.4. Assignments (Bài tập)
(*) Kế thừa từ `CourseContents`.

| Tên Cột | Kiểu Dữ Liệu | Đặc Tả | Mô Tả |
| :--- | :--- | :--- | :--- |
| `Id` | `UNIQUEIDENTIFIER` | PK/FK | Trỏ về `CourseContents.Id`. |
| `DueDate` | `DATETIME2` | Nullable | Hạn nộp bài. |
| `MaxScore` | `INT` | Not Null | Điểm tối đa (thang điểm 10 hoặc 100). |

---

## 5. PHÂN HỆ ĐÁNH GIÁ (ASSESSMENT)

### 5.1. Questions (Ngân hàng câu hỏi)
Lưu trữ các câu hỏi (độc lập với đề thi).

| Tên Cột | Kiểu Dữ Liệu | Đặc Tả | Mô Tả |
| :--- | :--- | :--- | :--- |
| `ContentText` | `NVARCHAR(MAX)` | Not Null | Nội dung câu hỏi. |
| `Type` | `INT` | Not Null | 1=Trắc nghiệm 1 đáp án, 2=Nhiều đáp án... |
| `TopicId` | `UNIQUEIDENTIFIER` | FK | Thuộc chủ đề nào (VD: Chương 1, Chương 2). |

### 5.2. Answers (Đáp án)
Các phương án trả lời cho câu hỏi.

| Tên Cột | Kiểu Dữ Liệu | Đặc Tả | Mô Tả |
| :--- | :--- | :--- | :--- |
| `QuestionId` | `UNIQUEIDENTIFIER` | FK | Thuộc câu hỏi nào. |
| `ContentText` | `NVARCHAR(MAX)` | Not Null | Nội dung đáp án (VD: "Đáp án A..."). |
| `IsCorrect` | `BIT` | Not Null | Là đáp án đúng hay sai. |

### 5.3. QuizQuestions (Cấu trúc đề)
Gán câu hỏi vào bài kiểm tra (Many-to-Many).

| Tên Cột | Kiểu Dữ Liệu | Đặc Tả | Mô Tả |
| :--- | :--- | :--- | :--- |
| `QuizId` | `UNIQUEIDENTIFIER` | FK | Bài kiểm tra nào. |
| `QuestionId` | `UNIQUEIDENTIFIER` | FK | Lấy câu hỏi nào. |
| `Points` | `INT` | Not Null | Câu này bao nhiêu điểm trong bài thi này. |

---

## 6. PHÂN HỆ THEO DÕI (TRACKING)

### 6.1. QuizSubmissions (Bài làm của SV)

| Tên Cột | Kiểu Dữ Liệu | Đặc Tả | Mô Tả |
| :--- | :--- | :--- | :--- |
| `QuizId` | `UNIQUEIDENTIFIER` | FK | Bài kiểm tra nào. |
| `StudentId` | `UNIQUEIDENTIFIER` | FK | Sinh viên nào làm. |
| `Status` | `NVARCHAR` | Not Null | `InProgress` (Đang làm), `Submitted` (Đã nộp). |
| `Score` | `FLOAT` | Not Null | Điểm số đạt được. |
| `TempData` | `NVARCHAR(MAX)` | Nullable | **JSON** chứa danh sách đáp án đang chọn (Auto-save). |
| `StartTime` | `DATETIME2` | Not Null | Thời điểm bắt đầu ấn nút làm bài. |
| `EndTime` | `DATETIME2` | Nullable | Thời điểm nộp bài. |
| `UpdatedAt` | `DATETIME2` | Nullable | Thời điểm lưu cuối cùng (Dùng để check resume). |

### 6.2. LessonProgresses (Tiến độ học)

| Tên Cột | Kiểu Dữ Liệu | Đặc Tả | Mô Tả |
| :--- | :--- | :--- | :--- |
| `LessonId` | `UNIQUEIDENTIFIER` | FK | Bài học nào. |
| `VideoProgressSeconds`| `INT` | Not Null | Sinh viên đã xem đến giây thứ bao nhiêu. |
| `IsCompleted` | `BIT` | Not Null | Đã hoàn thành bài học chưa. |

---
**Ghi chú chung:**
*   Các trường `Id`, `CreatedAt`, `UpdatedAt`, `IsDeleted` có trong **TẤT CẢ** các bảng (do kế thừa từ BaseEntity) nên không liệt kê lặp lại, trừ khi nó có vai trò nghiệp vụ đặc biệt (như `UpdatedAt` trong `QuizSubmissions`).
