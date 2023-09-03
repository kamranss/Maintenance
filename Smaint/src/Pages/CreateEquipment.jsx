import React from "react";
import SideBarEquipment from "../Components/SideBarEquipment";
import HeaderNav from "../Components/HeaderNav";
import TableHeader from "../Components/TableHeader";
import FormCreateEquipment from "../Components/Forms/FormCreateEquipment";
import EquipmentCreateSideBar from "../Components/SideBars/EquipmentCreateSideBar";

export const CreateEquipment = () => {
  return (
    <div className="department-main">
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
