import React, { useEffect, useState } from "react";
import TableHeader from "../Components/TableHeader";
import PaginationComponent from "../Components/PaginationComponent";
import axios from "axios";

import SideBarEquipment from "../Components/SideBarEquipment";
import TableMp from "../Components/Tables/TableMp";

const MpPage = () => {
  const [page, setPage] = useState(1);
  const [size, setSize] = useState(5);
  const [mpData, setMpData] = useState();

  useEffect(() => {
    axios
      .get("https://localhost:7066/api/MaintenancePlan/List", {
        params: { page: page, pageSize: size },
      })
      .then((res) => {
        console.log("Response:", res.data); // Log the entire response
        console.log("Items:", res.data); // Log the items array
        console.log("Current Page:", res.data.currentPage); // Log the current page
        console.log("Page Count:", res.data.pageCount); // Log the page count
        console.log("Total Count:", res.data.totalCount); // Log the total count
        setMpData(res.data); // Set the department data
      })
      .catch((err) => console.log(err));
  }, [page, size]);
  console.log(mpData);
  return (
    <div className="department-main">
      <div className="dep-mid">
        <SideBarEquipment />
        <div className="page-content">
          <div>
            <TableHeader />
            {mpData && (
              <>
                <TableMp
                  className="table"
                  thead={Object.keys(mpData?.items?.[0])}
                  rows={mpData?.items}
                />
                <PaginationComponent
                  page={page}
                  setPage={setPage}
                  recordSize={size}
                  count={mpData?.totalCount} // *4
                  size={size}
                  setSize={setSize}
                />
              </>
            )}
          </div>
        </div>
      </div>
    </div>
  );
};

export default MpPage;
