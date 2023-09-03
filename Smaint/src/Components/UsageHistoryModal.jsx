import React from "react";
import Modal from "@mui/material/Modal";
import { styled } from "@mui/material/styles";

const StyledModal = styled(Modal)`
  display: flex;
  align-items: center;
  justify-content: center;
`;

const UsageHistoryModal = ({
  modalOpen,
  selectedRowId,
  userInput,
  setModalOpen,
  setSelectedRowId,
  setUserInput,
  handleModalSubmit,
}) => {
  const handleClose = () => {
    setSelectedRowId(null);
    setUserInput("");
    setModalOpen(false);
  };

  const handleSubmit = () => {
    // TODO: Handle the submission, e.g., send Axios request
    handleClose();
  };

  return (
    <StyledModal
      open={modalOpen}
      onClose={handleClose}
      aria-labelledby="modal-title"
      aria-describedby="modal-description"
    >
      <div className="modal-content">
        <h2 id="modal-title">Usage History Details</h2>
        <p id="modal-description">Row ID: {selectedRowId}</p>

        <label htmlFor="userInput">User Input:</label>
        <input
          type="text"
          id="userInput"
          value={userInput}
          onChange={(e) => setUserInput(e.target.value)}
        />

        <button onClick={handleSubmit}>Submit</button>
        <button onClick={handleClose}>Close</button>
      </div>
    </StyledModal>
  );
};

export default UsageHistoryModal;
