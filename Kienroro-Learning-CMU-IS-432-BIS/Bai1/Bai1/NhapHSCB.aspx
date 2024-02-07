<%@ Page Title="NhapHSCB" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NhapHSCB.aspx.cs" Inherits="WebApplication6.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" action="CapNhatCanBo.aspx" method="post">
        <div style="text-align: center">
            <p style="border-bottom: solid; border-width: thin; font-size: 20pt; margin: 0; padding: 0; border-spacing: 0px">
                CHƯƠNG TRÌNH QUẢN LÝ CÁN BỘ VERSION 1.0
            </p>
            <br />
            <br />
            <p class="HeadTitle">NHẬP HỒ SƠ CÁN BỘ</p>
            <table class="Table">
                <tr class="CellSpace">
                    <td colspan="2" class="Tiêu_Đề_Chính">THÔNG TIN CÁ NHÂN</td>
                </tr>
                <tr>
                    <td class="Cột1">*Họ và tên</td>
                    <td class="Cột2">
                        <input type="text" id="HoVaTen" class="TextboxDài" />
                    </td>
                </tr>
                <tr>
                    <td class="Cột1">*Ngày sinh (ngày/tháng/năm)</td>
                    <td class="Cột2">
                        <select id="NgaySinh">
                            <option value="">1</option>
                            <option value="2">2</option>
                        </select>
                        /
   <select id="cboThangSinh">
       <option value="1">1</option>
       <option value="2">2</option>
       <option value="3">3</option>
       <option value="4">4</option>
       <option value="5">5</option>
       <option value="6">6</option>
       <option value="7">7</option>
       <option value="8">8</option>
       <option value="9">9</option>
       <option value="10">10</option>
       <option value="11">11</option>
       <option value="12">12</option>
   </select>
                        /


   <select id="NamSinh">
       <option value="1950">1950</option>
       <option value="1951">1951</option>
       <option value="1952">1952</option>
   </select>
                        Giới tính:
                        <input type="radio" id="optNam" checked="checked" />
                        Nam
                        <input type="radio" id="optNu" />Nữ
                    </td>
                </tr>
                <tr>
                    <td class="Cột1">Chức vụ hiện tại (Đảng, chính quyền,...)</td>
                    <td>
                        <input type="text" class="TextboxDài" /></td>
                </tr>
                <tr>
                    <td class="Cột1">*Quê quán</td>
                    <td class="Cột2">
                        <input type="text" class="TextboxDài" /></td>
                </tr>
                <tr>
                    <td class="Cột1">*Nơi ở hiện nay</td>
                    <td class="Cột2">
                        <input type="text" class="TextboxDài" /></td>
                </tr>
                <tr>
                    <td colspan="2" class="Tiêu_Đề_Chính">TRÌNH ĐỘ HỌC VẤN</td>
                </tr>
                <tr>
                    <td class="Cột1">Dân tộc : </td>
                    <td class="Cột2">
                        <input type="text" />
                        Tôn giáo:
                        <input type="text" />
                    </td>
                </tr>
                <tr>
                    <td class="Cột1">Thành phần gia đình:</td>
                    <td class="Cột2">
                        <input type="text" class="TextboxDài" /></td>
                </tr>
                <tr>
                    <td class="Cột1">Nghề trước khi tuyển dụng</td>
                    <td class="Cột2">
                        <input type="text" class="TextboxDài" /></td>
                </tr>
                <tr>
                    <td class="Cột1">Tham gia cách mạng: </td>
                    <td class="Cột2">Ngày
                        <input value="..../...../......" style="width: 15%; text-align: center"
                            onfocus="XuLyFocus(this);" onblur="XuLyLostFocus(this);" />
                        Tổ chức
                        <input style="width: 20%" />
                        Công tác
                        <input style="width: 20%" />
                    </td>
                </tr>
                <tr>
                    <td class="Cột1">Ngày vào Đảng: </td>
                    <td class="Cột2">
                        <input type="text" value="...../...../....." id="NgayVaoDang"
                            class="NgayThang"
                            onfocus="XuLyFocus(this);" onblur="XuLyLostFocus(this);" />
                        ngày vào chính thức
                        <input type="text" class="NgayThang"
                            value="...../...../....."
                            onfocus="XuLyFocus(this);" onblur="XuLyLostFocus(this);" />
                    </td>
                </tr>


                <tr>
                    <td class="Cột1">Ngày nhập ngũ:</td>
                    <td class="Cột2">
                        <input type="text" value="..../...../...." class="NgayThang"
                            onfocus="XuLyFocus(this);" onblur="XuLyLostFocus(this);" />
                        ngày xuất ngũ
                        <input type="text" class="NgayThang" value="..../...../....."
                            onfocus="XuLyFocus(this);" onblur="XuLyLostFocus(this);" />
                    </td>
                </tr>


                <tr>
                    <td class="Cột1">*Trình độ Văn hóa: </td>
                    <td class="Cột2">
                        <input style="width: 15%" />
                        Học hàm:
   <select>
       <option value="">-----</option>
       <option value="Thạc Sĩ">Thạc sĩ </option>
       <option value="Tiến Sĩ">Tiến sĩ</option>
   </select>
                        Học vị :
   <select>
       <option value="">-----</option>
       <option value="Giáo sư">Giáo sư</option>
       <option value="Phó giáo sư">Phó giáo sư</option>
   </select>
                    </td>
                </tr>


                <tr>
                    <td class="Cột1">Lý luận chính trị </td>
                    <td class="Cột2">
                        <select>
                            <option>-----</option>
                            <option value="Sơ cấp">Sơ cấp</option>
                            <option value="Trung cấp">Trung cấp</option>
                            <option value="Cao cấp">Cao cấp</option>
                            <option value="Cử nhân">Cử nhân</option>
                        </select>
                    </td>
                </tr>


                <tr>
                    <td class="Cột1">Trình độ ngoại ngữ</td>
                    <td class="Cột2">Anh
                        <select>
                            <option>-----</option>
                            <option value="A">A</option>
                            <option value="B">B</option>
                            <option value="C">C</option>
                        </select>
                        Nga 
                        <select>
                            <option>-----</option>
                            <option value="A">A</option>
                            <option value="B">B</option>
                            <option value="C">C</option>
                        </select>
                        Pháp
                        <select>
                            <option>-----</option>
                            <option value="A">A</option>
                            <option value="B">B</option>
                            <option value="C">C</option>
                        </select>
                    </td>
                </tr>


                <tr>
                    <td class="Cột1">*Ngạch công chức, viên chức:</td>
                    <td class="Cột2">
                        <input style="width: 20%" />
                        Mã số:
                        <input style="width: 15%" />
                        *Hệ số lương:
                        <input style="width: 15%" />
                    </td>
                </tr>


                <tr>
                    <td class="Cột1">Danh hiệu được phong (năm): </td>
                    <td class="Cột2">
                        <input class="TextboxDài" /></td>
                </tr>


                <tr>
                    <td class="Cột1">Sở trường công tác:</td>
                    <td class="Cột2">
                        <input class="TextboxDài" /></td>
                </tr>


                <tr>
                    <td class="Cột1">Khen thưởng (huân,huy chương cao nhất)</td>
                    <td class="Cột2">
                        <input class="TextboxDài" /></td>
                </tr>


                <tr>
                    <td class="Cột1">Kỷ luật (đảng, chính quyền, năm, lý do, hình thức)</td>
                    <td class="Cột2">
                        <textarea class="TextboxDài" cols="50" rows="3"></textarea>
                    </td>
                </tr>


                <tr class="Tiêu_Đề_Chính">
                    <td colspan="2">ĐÀO TẠO, BỒI DƯỠNG CHUYÊN MÔN, NGHIỆP VỤ, LÝ LUẬN, NGOẠI NGỮ
                    </td>
                </tr>
                <tr>
                    <td class="Cột1">Ghi rõ Tên trường, ngành học, thời gian, loại hình,văn bằng, chứng chỉ</td>
                    <td>
                        <textarea class="TextboxDài" cols="100" rows="5"></textarea>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="color: Blue">** Loại hình: Chính qui, tại chức, chuyên tu, bồi dưỡng; văn bằng: Tiến sĩ,
 thạc sĩ, cử nhân, kỹ sư.
                    </td>
                </tr>


                <tr class="Tiêu_Đề_Chính">
                    <td colspan="2">TÓM TẮT QUÁ TRÌNH CÔNG TÁC</td>
                </tr>
                <tr>
                    <td class="Cột1">Ghi rõ thời gian bắt đầu và kết thúc; chức danh, chức vụ,
đơn vị công tác tương ứng)</td>
                    <td>
                        <textarea class="TextboxDài" cols="100" rows="5"></textarea></td>
                </tr>


                <tr class="Tiêu_Đề_Chính">
                    <td colspan="2">Đặc điểm lịch sử bản thân</td>
                </tr>


                <tr>
                    <td class="Cột1">Đặc điểm lịch sử bản thân</td>
                    <td class="Cột2">
                        <textarea class="TextboxDài" cols="100" rows="5"></textarea>
                    </td>
                </tr>


                <tr>
                    <td class="Cột1">Quan hệ với người nước ngoài</td>
                    <td class="Cột2">
                        <textarea class="TextboxDài" cols="100" rows="5"></textarea>
                    </td>
                </tr>


                <tr>
                    <td class="Cột1">Quan hệ gia đình (Bố, mẹ, anh chị em ruột)</td>
                    <td class="Cột2">
                        <textarea class="TextboxDài" cols="100" rows="5"></textarea>
                    </td>
                </tr>


                <tr>
                    <td class="Cột1">Hoàn cảnh kinh tế gia đình</td>
                    <td class="Cột2">
                        <textarea class="TextboxDài" cols="100" rows="5"></textarea>
                    </td>
                </tr>
            </table>
            <br />

            <table class="Table" style="border: 0">
                <tr>
                    <td style="text-align: right">
                        <input type="submit" value="     Cập nhật   "
                            onclick="return KiemTra();" /></td>
                    <td style="text-align: left">
                        <input type="reset" value=" Nhập mới “" /></td>
                </tr>
            </table>
        </div>
    </form>
    <script language="javascript" type="text/javascript">
        var Giá_Trị_Cũ;
        /// Hàm xử lý khi người dùng bấm vào nút Nhập
        function KiemTra() {
            if (form1.HoVaTen.value.length == 0) {
                alert("Họ tên phải khác rỗng !");
                form1.HoVaTen.focus();
                return false;
            }
            if (isNaN(form1.NgaySinh.value) == false) {
                alert("Ngày sinh phải là số ");
                form1.NgaySinh.focus();
                return false;
            }
        }
        return true;
}
        /// Hàm xử lý khi phần tử nhận được focus 
        function XuLyFocus(txt) {
            Giá_Trị_Cũ = txt.value;
            txt.value = "";
        }

        /// Hàm xử lý khi phần tử mất focus 
        function XuLyLostFocus(txt) {
            if (txt.value == "") txt.value = Giá_Trị_Cũ;
        }
    </script>
</asp:Content>
