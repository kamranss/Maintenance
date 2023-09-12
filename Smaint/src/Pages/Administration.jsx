import React, { useEffect, useState } from "react";
import { NavLink } from "react-router-dom";
// import TableComponent from "../Components/Table";
import TableDepartment from "../Components/Tables/TableDepartment";
import TableHeader from "../Components/TableHeader";
import TablePart from "../Components/Tables/TablePart";
import TableModel from "../Components/Tables/TableModel";
// import TableOperation_Sites from "../Components/Tables/TableOperation_Sites";
import TableManufacture from "../Components/Tables/TableManufacture";
import PaginationComponent from "../Components/PaginationComponent";
import axios from "axios";
import { TableHead } from "@mui/material";
// import SideBarEquipment from "../Components/SideBarEquipment";
import SideBarAdministration from "../Components/SideBarAdministration";
import TableOperation_Sites from "../Components/Tables/TableOperation_Sites";
// import HeaderNav from "../Components/HeaderNav";

import {
  ModelAll,
  DepartmentAll,
  ManufactureAll,
  OperationSiteAll,
  PartAll,
} from "../Contants/Urls"; // Adjust the path accordingly

const Administration = () => {
  const [page, setPage] = useState(1);
  const [size, setSize] = useState(10);
  const [activeTab, setActiveTab] = useState(0); // Track the active tab
  const [data, setData] = useState(null);

  const apiEndpoints = [
    // "https://localhost:7066/api/Department/All",
    // "https://localhost:7066/api/Part/All",
    // "https://localhost:7066/api/Manufacture/All",
    // "https://localhost:7066/api/Model/All",
    // "https://localhost:7066/api/OperationSite/All",

    DepartmentAll,
    PartAll,
    ManufactureAll,
    ModelAll,
    OperationSiteAll,
  ];

  const fetchData = (index) => {
    const endpoint = apiEndpoints[index];

    axios
      .get(endpoint, {
        params: { page: page, pageSize: size },
      })
      .then((res) => {
        setData(res.data);
        console.log(res.data);
      })
      .catch((err) => console.log(err));
  };

  useEffect(() => {
    const token = localStorage.getItem("token");
    console.log("Token:", token); // Log the token
    axios.defaults.headers.common["Authorization"] = `Bearer ${token}`;
    fetchData(activeTab); // Fetch data when the component mounts or activeTab changes
  }, [activeTab, page, size]);

  return (
    <div className="department-main">
      <div className="dep-mid">
        <SideBarAdministration
          activeTab={activeTab}
          onTabChange={setActiveTab}
        />

        <div className="page-content">
          <div>
            <TableHeader />

            {activeTab === 0 && data && (
              <TableDepartment
                className="table"
                thead={Object.keys(data?.items?.[0])}
                rows={data?.items}
              />
            )}
            {activeTab === 1 && data && (
              <TablePart
                className="table"
                thead={Object.keys(data?.items?.[0])}
                rows={data?.items}
              />
            )}
            {activeTab === 2 && data && (
              <TableManufacture
                className="table"
                thead={Object.keys(data?.items?.[0])}
                rows={data?.items}
              />
            )}
            {activeTab === 3 && data && (
              <TableModel
                className="table"
                thead={Object.keys(data?.items?.[0])}
                rows={data?.items}
              />
            )}
            {activeTab === 4 && data && (
              <TableOperation_Sites
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

export default Administration;
