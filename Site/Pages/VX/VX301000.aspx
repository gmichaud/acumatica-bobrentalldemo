<%@ Page AutoEventWireup="true" CodeFile="VX301000.aspx.cs" Inherits="Page_VX301000" Language="C#" MasterPageFile="~/MasterPages/FormDetail.master" Title="Untitled Page" ValidateRequest="false" %>

<%@ MasterType VirtualPath="~/MasterPages/FormDetail.master" %>

<asp:Content ID="cont1" runat="Server" ContentPlaceHolderID="phDS">
    <px:PXDataSource ID="ds" runat="server" PrimaryView="Tools" TypeName="Velixo.ToolRental.ToolManagement" Visible="True" Width="100%">
        <CallbackCommands>
            <px:PXDSCallbackCommand CommitChanges="True" Name="Save">
            </px:PXDSCallbackCommand>
        </CallbackCommands>
    </px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" runat="Server" ContentPlaceHolderID="phF">
    <px:PXFormView ID="form" runat="server" DataMember="Tools" DataSourceID="ds" Style="z-index: 100" Width="100%">
        <Template>
            <px:PXLayoutRule ID="PXLayoutRule1" runat="server" ControlSize="M" LabelsWidth="SM" StartColumn="True">
            </px:PXLayoutRule>
            <px:PXSelector ID="edToolCD" runat="server" DataField="ToolCD">
            </px:PXSelector>
            <px:PXTextEdit ID="edDescription" runat="server" DataField="Description">
            </px:PXTextEdit>
            <px:PXNumberEdit ID="edCost" runat="server" DataField="Cost">
            </px:PXNumberEdit>
            <px:PXTextEdit ID="edSerialNumber" runat="server" CommitChanges="true" DataField="SerialNumber">
            </px:PXTextEdit>
        </Template>
        <AutoSize Container="Window" Enabled="True" MinHeight="200" />
    </px:PXFormView>
</asp:Content>
<asp:Content ID="cont3" runat="Server" ContentPlaceHolderID="phG">
    <px:PXGrid ID="grid" runat="server" Caption="Tool Rentals" DataSourceID="ds" Height="150px" SkinID="Details" Style="z-index: 100" Width="100%">
        <Levels>
            <px:PXGridLevel DataMember="Rentals">
                <RowTemplate>
                    <px:PXLayoutRule ID="PXLayoutRule2" runat="server" ControlSize="XM" LabelsWidth="SM" StartColumn="True">
                    </px:PXLayoutRule>
                    <px:PXSelector ID="edCustomerID" runat="server" DataField="CustomerID">
                    </px:PXSelector>
                    <px:PXDateTimeEdit ID="edStartDate" runat="server" DataField="StartDate">
                    </px:PXDateTimeEdit>
                    <px:PXDateTimeEdit ID="edEndDate" runat="server" DataField="EndDate">
                    </px:PXDateTimeEdit>
                </RowTemplate>
                <Columns>
                    <px:PXGridColumn DataField="CustomerID" TextAlign="Left" Width="200px">
                    </px:PXGridColumn>
                    <px:PXGridColumn DataField="StartDate" TextAlign="Right" Width="100px">
                    </px:PXGridColumn>
                    <px:PXGridColumn DataField="EndDate" TextAlign="Right" Width="100px">
                    </px:PXGridColumn>
                </Columns>
                <Layout FormViewHeight="" />
            </px:PXGridLevel>
        </Levels>
        <AutoSize Container="Window" Enabled="True" MinHeight="150" />
        <ActionBar>
            <Actions>
                <NoteShow Enabled="False" />
            </Actions>
        </ActionBar>
    </px:PXGrid>
</asp:Content>
