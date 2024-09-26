import React from "react";
import SideBarEquipment from "../Components/SideBarEquipment";
import TableHeader from "../Components/TableHeader";
import FormCreateEquipment from "../Components/Forms/FormCreateEquipment";
import EquipmentCreateSideBar from "../Components/SideBars/EquipmentCreateSideBar";
import HeaderNav from "../Components/Common/HeaderNav";

export const CreateEquipment = () => {
  return (
    <div className="department-main">
      <HeaderNav />;
      <div className="dep-mid">
        {/* <SideBarEquipment /> */}
        <EquipmentCreateSideBar />
        <div className="page-content">
          <TableHeader />
          <FormCreateEquipment />
        </div>
      </div>
    </div>
  );
};
