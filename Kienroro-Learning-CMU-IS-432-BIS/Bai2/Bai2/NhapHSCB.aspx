<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NhapHSCB.aspx.cs" Inherits="Bai2.NhapHSCB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" action="CapNhatCanBo.aspx" method="post" >
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
                        <asp:TextBox runat="server" ID="HoVaTen" class="TextboxDài" />
                    </td>
                </tr>
                <tr>
                    <td class="Cột1">*Ngày sinh (ngày/tháng/năm)</td>
                    <td class="Cột2">
                        <asp:ListBox Rows="1" ID="cboNgaySinh" runat="server"></asp:ListBox>
                        /
      <asp:ListBox Rows="1" ID="cboThangSinh" runat="server"></asp:ListBox>
                        /
      <asp:ListBox Rows="1" ID="cboNamSinh" runat="server"></asp:ListBox>
                        Giới tính:
                        <asp:RadioButton runat="server" type="radio" ID="optNam" GroupName="GT" Checked="true" />
                        Nam
                        <asp:RadioButton runat="server" ID="optNu" GroupName="GT" />Nữ
                    </td>
                </tr>
                <tr>
                    <td class="Cột1">Chức vụ hiện tại (Đảng, chính quyền,...)</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtChucVu" CssClass="TextboxDài" /></td>
                </tr>
                <tr>
                    <td class="Cột1">*Quê quán</td>
                    <td class="Cột2">
                        <asp:TextBox runat="server" ID="txtQueQuan" CssClass="TextboxDài" /></td>
                </tr>

                <tr>
                    <td class="Cột1">*Nơi ở hiện nay</td>
                    <td class="Cột2">
                        <asp:TextBox runat="server" ID="txtNoiOHienNay" CssClass="TextboxDài" />
                    </td>
                </tr>

                <tr>
                    <td colspan="2" class="Tiêu_Đề_Chính">TRÌNH ĐỘ HỌC VẤN</td>
                </tr>

                <tr>
                    <td class="Cột1">Dân tộc : </td>
                    <td class="Cột2">
                        <asp:TextBox runat="server" ID="txtDanToc" Text="Kinh" />
                        Tôn giáo:
                        <asp:TextBox runat="server" ID="txtTonGiao" Text="Không" />
                    </td>
                </tr>
                <tr>
                    <td class="Cột1">Thành phần gia đình:</td>
                    <td class="Cột2">
                        <asp:TextBox runat="server" ID="txtThanhPhan" CssClass="TextboxDài" /></td>
                </tr>
                <tr>
                    <td class="Cột1">Nghề trước khi tuyển dụng</td>
                    <td class="Cột2">
                        <asp:TextBox runat="server" ID="txtNgheTruocKhiTuyen" CssClass="TextboxDài" />
                    </td>
                </tr>

                <tr>
                    <td class="Cột1">Tham gia cách mạng: </td>
                    <td class="Cột2">Ngày
                        <asp:TextBox runat="server" ID="txtNgayThamGiaCM" Text="..../.../...."
                            Style="width: 15%; text-align: center" onfocus="XuLyFocus(this);" onblur="XuLyLostFocus(this);" />
                        Tổ chức
                        <asp:TextBox runat="server" ID="txtToChuc" Style="width: 20%" />
                        Công tác
                        <asp:TextBox runat="server" ID="txtCongTac" Style="width: 20%" />
                    </td>
                </tr>

                <tr>
                    <td class="Cột1">Ngày vào Đảng: </td>
                    <td class="Cột2">
                        <asp:TextBox runat="server" ID="txtNgayVaoDang" Text=".../.../..." CssClass="NgayThang"
                            onfocus="XuLyFocus(this);" onblur="XuLyLostFocus(this);" />
                        ngày vào chính thức
                        <asp:TextBox runat="server" ID="txtThangVaoDang"
                            CssClass="NgayThang" Text=".../.../..." onfocus="XuLyFocus(this)" onblur="XuLyLostFocus(this)" />
                    </td>
                </tr>

                <tr>
                    <td class="Cột1">Ngày nhập ngũ:</td>
                    <td class="Cột2">
                        <input type="text" value="..../.../...." class="NgayThang"
                            onfocus="XuLyFocus(this);" onblur="XuLyLostFocus(this);" />
                        ngày xuất ngũ
                        <input type="text" class="NgayThang" value="..../.../..."
                            onfocus="XuLyFocus(this);" onblur="XuLyLostFocus(this);" />
                    </td>
                </tr>

                <tr>
                    <td class="Cột1">*Trình độ Văn hóa: </td>
                    <td class="Cột2">
                        <input style="width: 15%" />
                        Học hàm:
      <select runat="server" id="cboHocHam">
          <option value="">-----</option>
          <option value="Thạc Sĩ">Thạc sĩ </option>
          <option value="Tiến Sĩ">Tiến sĩ</option>
      </select>
                        Học vị :
      <select runat="server" id="cboHocVi">
          <option value="">-----</option>
          <option value="Giáo sư">Giáo sư</option>
          <option value="Phó giáo sư">Phó giáo sư</option>
      </select>
                    </td>
                </tr>

                <tr>
                    <td class="Cột1">Lý luận chính trị </td>
                    <td class="Cột2">
                        <select runat="server" id="cboTrinhDoLyLuan">
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
                        <select runat="server" id="cboTiengAnh">
                            <option>-----</option>
                            <option value="A">A</option>
                            <option value="B">B</option>
                            <option value="C">C</option>
                        </select>
                        Nga 
                        <select runat="server" id="cboTiengNga">
                            <option>-----</option>
                            <option value="A">A</option>
                            <option value="B">B</option>
                            <option value="C">C</option>
                        </select>
                        Pháp
                        <select runat="server" id="cboTiengPhap">
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
                        <asp:TextBox runat="server" ID="txtNgach" Style="width: 20%" />
                        Mã số:
                        <asp:TextBox runat="server" ID="txtMaNgach" Style="width: 15%" />
                        *Hệ số lương:
                        <asp:TextBox runat="server" ID="txtHeSoLuong" Style="width: 15%" />
                    </td>
                </tr>

                <tr>
                    <td class="Cột1">Danh hiệu được phong (năm): </td>
                    <td class="Cột2">
                        <asp:TextBox runat="server" ID="txtDanhHieu" CssClass="TextboxDài" />
                    </td>
                </tr>

                <tr>
                    <td class="Cột1">Sở trường công tác:</td>
                    <td class="Cột2">
                        <asp:TextBox runat="server" ID="txtSoTruongCT" CssClass="TextboxDài" />
                    </td>
                </tr>

                <tr>
                    <td class="Cột1">Khen thưởng (huân,huy chương cao nhất)</td>
                    <td class="Cột2">
                        <asp:TextBox runat="server" ID="txtKhenThuong" CssClass="TextboxDài" />
                    </td>
                </tr>

                <tr>
                    <td class="Cột1">Kỷ luật (đảng, chính quyền, năm, lý do, hình thức)</td>
                    <td class="Cột2">
                        <asp:TextBox runat="server" ID="txtKyLuat" TextMode="MultiLine" CssClass="TextboxDài" Rows="5" Columns="80"></asp:TextBox>
                    </td>
                </tr>

                <tr class="Tiêu_Đề_Chính">
                    <td colspan="2">ĐÀO TẠO, BỒI DƯỠNG CHUYÊN MÔN, NGHIỆP VỤ, LÝ LUẬN, NGOẠI NGỮ
                    </td>
                </tr>

                <tr>
                    <td class="Cột1">Ghi rõ Tên trường, ngành học, thời gian, loại hình,văn bằng, chứng chỉ
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtQuaTrinhDaoTao"
                            CssClass="TextboxDài" TextMode="MultiLine" Columns="100" Rows="5"></asp:TextBox>
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
                        <asp:TextBox runat="server" ID="txtQuaTrinhCongTac"
                            CssClass="TextboxDài" TextMode="MultiLine" Columns="100" Rows="5">
                        </asp:TextBox>
                    </td>
                </tr>

                <tr class="Tiêu_Đề_Chính">
                    <td colspan="2">Đặc điểm lịch sử bản thân</td>
                </tr>

                <tr>
                    <td class="Cột1">Đặc điểm lịch sử bản thân</td>
                    <td class="Cột2">
                        <asp:TextBox runat="server" ID="txtDDBanThan"
                            CssClass="TextboxDài" TextMode="MultiLine" Columns="100" Rows="5">
                        </asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="Cột1">Quan hệ với người nước ngoài</td>
                    <td class="Cột2">
                        <asp:TextBox runat="server" ID="txtQHNguoiNN"
                            CssClass="TextboxDài" TextMode="MultiLine" Columns="100" Rows="5">
                        </asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="Cột1">Quan hệ gia đình (Bố, mẹ, anh chị em ruột)</td>
                    <td class="Cột2">
                        <asp:TextBox runat="server" ID="txtQHGD" CssClass="TextboxDài"
                            TextMode="MultiLine" Columns="100" Rows="5"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="Cột1">Hoàn cảnh kinh tế gia đình</td>
                    <td class="Cột2">
                        <asp:TextBox runat="server" ID="txtHoanCanhKT" CssClass="TextboxDài"
                            TextMode="MultiLine" Columns="100" Rows="5"></asp:TextBox>
                    </td>
                </tr>
            </table>


            <asp:Label runat="server" ID="lblTrangThai" Visible="false" Style="text-align: center">
            </asp:Label>

            <br />
            <table class="Table" style="border: 0">
                <tr>
                    <td style="text-align: right">
                        <asp:Button runat="server" ID="cmdSubmit" Text="     Cập nhật   " OnClick="cmdSubmit_Click"/>
                    </td>

                    <td style="text-align: left">
                        <input type="reset" value=" Nhập mới " />
                    </td>
                </tr>
            </table>
        </div>
    </form>

    <script language="javascript" type="text/javascript">
        var Giá_Trị_Cũ;

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
