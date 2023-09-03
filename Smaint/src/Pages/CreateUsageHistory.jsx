import React from "react";
import TableHeader from "../Components/TableHeader";
import FormCreateUsageHistory from "../Components/Forms/FormCreateUsageHistory";
import SideBarUsageHistory from "../Components/SideBars/SideBarUsageHistory";

export const CreateUsageHistory = () => {
  return (
    <div className="department-main">
      <div className="dep-mid">
        <SideBarUsageHistory />
        <div className="page-content">
          <TableHeader />
          <FormCreateUsageHistory />
        </div>
      </div>
    </div>
  );
};
export default CreateUsageHistory; // Export as default
