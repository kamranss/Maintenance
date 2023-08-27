import React from "react";
import SideBarEquipment from "../Components/SideBarEquipment";
import HeaderNav from "../Components/HeaderNav";
import TableHeader from "../Components/TableHeader";
import FormCreateEquipment from "../Components/Forms/FormCreateEquipment";

export const CreateEquipment = () => {
  return (
    <div className="department-main">
      <div className="dep-mid">
        <SideBarEquipment />
        <div className="page-content">
          <TableHeader />
          <FormCreateEquipment />
        </div>
      </div>
    </div>
  );
};
