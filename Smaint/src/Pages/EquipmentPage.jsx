// import React, { useState } from "react";
import { NavLink } from "react-router-dom";
import axios from "axios";
import React, { useEffect, useState } from "react";
// import TableComponent from "../Components/Table";
// import TableMui from "../Components/TableMui";
import PaginationComponent from "../Components/PaginationComponent";
import SideBarEquipment from "../Components/SideBarEquipment";
import TableHeader from "../Components/TableHeader";
import TableEquipment from "../Components/Tables/TableEquipment";

const EquipmentPage = () => {
  // const [page, setPage] = useState(3);

  const [page, setPage] = useState(1);
  const [size, setSize] = useState(5);
  const [activeTab, setActiveTab] = useState(0); // Track the active tab
  const [data, setData] = useState();

  // useEffect(() => {
  //   axios
  //     .get("https://localhost:7066/api/Department/All", {
  //       params: { page: page, pageSize: size },
  //     })
  //     .then((res) => setDepartmentdata(res.data.result.data));
  // }, [page, size]);

  const apiEndpoints = [
    "https://localhost:7066/api/Equipment/FindEquipmentsByDepartmentId",
    "https://localhost:7066/api/Equipment/FindEquipmentsByDepartmentId",
    "https://localhost:7066/api/Equipment/FindEquipmentsByDepartmentId",
    "https://localhost:7066/api/Equipment/FindEquipmentsByDepartmentId",
    "https://localhost:7066/api/Equipment/FindEquipmentsByDepartmentId",
    "https://localhost:7066/api/Equipment/FindEquipmentsByDepartmentId",
    "https://localhost:7066/api/Equipment/FindEquipmentsByDepartmentId",
    "https://localhost:7066/api/Equipment/FindEquipmentsByDepartmentId",
    "https://localhost:7066/api/Equipment/FindEquipmentsByDepartmentId",
  ];

  const fetchData = (index) => {
    const endpoint = apiEndpoints[index];

    axios
      .get(endpoint, {
        params: { page: page, pageSize: size, id: index + 1 },
      })
      .then((res) => {
        setData(res.data);
      })
      .catch((err) => console.log(err));
  };

  useEffect(() => {
    fetchData(activeTab);
  }, [activeTab, page, size]);

  console.log(data);
  // useEffect(() => {
  //   axios
  //     .get(
  //       "https://localhost:7066/api/Equipment/FindEquipmentsByDepartmentId",
  //       {
  //         params: { page: page, pageSize: size },
  //       }
  //     )
  //     .then((res) => {
  //       console.log("Response:", res.data); // Log the entire response
  //       console.log("Items:", res.data); // Log the items array
  //       console.log("Current Page:", res.data.currentPage); // Log the current page
  //       console.log("Page Count:", res.data.pageCount); // Log the page count
  //       console.log("Total Count:", res.data.totalCount); // Log the total count
  //       setEquipmentData(res.data); // Set the department data
  //     })
  //     .catch((err) => console.log(err));
  // }, [page, size]);

  return (
    // <div className="department-main">
    //   <div className="dep-mid">
    //     <SideBarEquipment />
    //     <div className="page-content">
    //       {/* <div>
    //         <TableHeader />
    //         <TableMui className="table" />
    //         <PaginationComponent page={page} setPage={setPage} />
    //       </div> */}

    //       <div>
    //         <TableHeader />
    //         {equipmentData && (
    //           <>
    //             <TableEquipment
    //               className="table"
    //               thead={Object.keys(equipmentData?.items?.[0])}
    //               rows={equipmentData?.items}
    //             />
    //             <PaginationComponent
    //               page={page}
    //               setPage={setPage}
    //               recordSize={size}
    //               count={equipmentData?.totalCount} // *4
    //               size={size}
    //               setSize={setSize}
    //             />
    //           </>
    //         )}
    //       </div>
    //     </div>
    //   </div>
    // </div>

    <div className="department-main">
      <div className="dep-mid">
        <SideBarEquipment activeTab={activeTab} onTabChange={setActiveTab} />
        <div className="page-content">
          <div>
            <TableHeader />

            {activeTab === 0 && data && (
              <TableEquipment
                className="table"
                thead={Object.keys(data?.items?.[0])}
                rows={data?.items}
              />
            )}
            {activeTab === 1 && data && (
              <TableEquipment
                className="table"
                thead={Object.keys(data?.items?.[0])}
                rows={data?.items}
              />
            )}
            {activeTab === 2 && data && (
              <TableEquipment
                className="table"
                thead={Object.keys(data?.items?.[0])}
                rows={data?.items}
              />
            )}
            {activeTab === 3 && data && (
              <TableEquipment
                className="table"
                thead={Object.keys(data?.items?.[0])}
                rows={data?.items}
              />
            )}
            {activeTab === 4 && data && (
              <TableEquipment
                className="table"
                thead={Object.keys(data?.items?.[0])}
                rows={data?.items}
              />
            )}
            {activeTab === 5 && data && (
              <TableEquipment
                className="table"
                thead={Object.keys(data?.items?.[0])}
                rows={data?.items}
              />
            )}
            {activeTab === 6 && data && (
              <TableEquipment
                className="table"
                thead={Object.keys(data?.items?.[0])}
                rows={data?.items}
              />
            )}
            {activeTab === 7 && data && (
              <TableEquipment
                className="table"
                thead={Object.keys(data?.items?.[0])}
                rows={data?.items}
              />
            )}
            {activeTab === 8 && data && (
              <TableEquipment
                className="table"
                thead={Object.keys(data?.items?.[0])}
                rows={data?.items}
              />
            )}
            <PaginationComponent
              page={page}
              setPage={setPage}
              recordSize={size}
              count={data?.totalCount} // *4
              size={size}
              setSize={setSize}
            />
          </div>
        </div>
      </div>
    </div>
  );
};

export default EquipmentPage;
