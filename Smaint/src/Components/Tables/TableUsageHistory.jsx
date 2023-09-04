// import * as React from "react";
import React, { useState } from "react";
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
// import UsageHistoryModal from "../Components/UsageHistoryModal";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";
import moment from "moment";
import { NavLink } from "react-router-dom";

export default function TableUsageHistory({ thead = [], rows = [] }) {
  const [modalOpen, setModalOpen] = useState(false);
  const [selectedRowId, setSelectedRowId] = useState(null);
  const [userInput, setUserInput] = useState("");

  const openModal = (rowId) => {
    setSelectedRowId(rowId);
    setModalOpen(true);
  };

  const closeModal = () => {
    setSelectedRowId(null);
    setUserInput("");
    setModalOpen(false);
  };

  const handleUserInput = (e) => {
    setUserInput(e.target.value);
  };

  const handleModalSubmit = () => {
    // TODO: Send Axios request with userInput and selectedRowId
    // Reset the modal state
    closeModal();
  };
  return (
    <div>
      <TableContainer
        component={Paper}
        sx={{ borderTopLeftRadius: 0, borderTopRightRadius: 0 }}
      >
        <Table sx={{ minWidth: 650 }} aria-label="simple table">
          <TableHead>
            <TableRow>
              {thead?.map((th, key) => (
                <TableCell key={key}>{th}</TableCell>
              ))}
            </TableRow>
          </TableHead>

          <TableBody>
            {rows.map((row, key) => {
              const statusClass =
                row.status === "ONGOING"
                  ? "row-start"
                  : row.status === "Finished"
                  ? "row-end"
                  : row.status === "CANCELED"
                  ? "row-CNL"
                  : "";

              return (
                <TableRow
                  key={key}
                  // onClick={() => onRowClick(row.id)}
                  // className={`row ${statusClass}`} // Add 'row' class and status class
                  sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
                >
                  <TableCell align="left">{row?.id}</TableCell>
                  <TableCell align="left">{row?.equipmentName}</TableCell>
                  <TableCell align="left">{row?.operationName}</TableCell>
                  <TableCell align="left">
                    {row?.startUsageHourValue || "-"}
                  </TableCell>
                  <TableCell align="left">
                    {row?.endUsageHourValue || "-"}
                  </TableCell>

                  {/* <TableCell align="left">{row?.operatorName || "-"}</TableCell> */}
                  <TableCell align="left">{row?.operatorName || "-"}</TableCell>
                  <TableCell align="left">
                    {row?.totalUsageValue || "-"}
                  </TableCell>
                  <TableCell align="left">
                    {moment(row?.startDate).format("DD-MM-YYYY") || "-"}
                  </TableCell>
                  <TableCell align="left">
                    {moment(row?.endDate).format("DD-MM-YYYY") || "-"}
                  </TableCell>

                  <TableCell
                    className={`${
                      row.status === "ONGOING"
                        ? "row-start"
                        : row.status === "FINISHED"
                        ? "row-end"
                        : row.status === "CANCELED"
                        ? "row-cnl"
                        : ""
                    }`}
                    align="left"
                  >
                    {row?.status || "-"}
                  </TableCell>
                  <TableCell align="left">
                    <TableCell align="left">{row?.totalTime || "-"}</TableCell>
                  </TableCell>
                  <TableCell align="left">
                    <button onClick={() => openModal(row.id)}>Open</button>
                  </TableCell>
                  <TableCell align="left">
                    <NavLink
                      to={{
                        pathname: "/usageHistoryDetail",
                        search: `?id=${row.id}`,
                      }}
                    >
                      <button>
                        <i class="fa-solid fa-circle-info"></i>
                      </button>
                    </NavLink>
                  </TableCell>
                </TableRow>
              );
            })}
          </TableBody>
        </Table>
      </TableContainer>
      {/* <UsageHistoryModal
        modalOpen={modalOpen}
        selectedRowId={selectedRowId}
        userInput={userInput}
        setModalOpen={setModalOpen}
        setSelectedRowId={setSelectedRowId}
        setUserInput={setUserInput}
        handleModalSubmit={handleModalSubmit}
      /> */}
    </div>
  );
}
