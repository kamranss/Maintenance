import React, { useEffect, useState } from "react";
import axios from "axios";
// import FormInputYear from "../FormFields/FormInputYear";
// import { FormControl, FormGroup, FormLabel } from "react-bootstrap";

// import { FormControl, FormGroup, FormLabel, Button } from "@mui/material";
// import { makeStyles } from "@mui/styles";
// import "bootstrap/dist/css/bootstrap.min.css";
import {
  FormControl,
  FormGroup,
  FormLabel,
  Button,
  TextField,
  Select,
  MenuItem,
  // InputLabel,
  styled,
  // ThemeProvider,
  createTheme,
  Autocomplete,
  debounce,
  Popper,
} from "@mui/material";
// import { styled } from "@mui/material/styles";

const FormCreateEquipment = () => {
  // const [enteredName, setEnteredName] = useState("");

  const [models, setModels] = useState([]); // State to hold fetched models
  const [selectedModel, setSelectedModel] = useState(null);
  const [selectedModelId, setSelectedModelId] = useState(""); // State to hold selected model ID
  const [searchQuery, setSearchQuery] = useState(""); // State to hold search query

  const [Types, setTypes] = useState([]);
  const [selectedType, setSelectedType] = useState(null);
  const [selectedTypelId, setSelectedTypeId] = useState(""); // State to hold selected model ID
  const [searchQueryfortypes, setSearchQueryfortypes] = useState(""); // State to hold search query

  const [formData, setFormData] = useState({}); // State to hold form data

  // const [filteredModels, setFilteredModels] = useState([]); // State to hold filtered models
  const theme = createTheme();

  // const CustomPopper = React.forwardRef(function CustomPopper(props, ref) {
  //   return (
  //     <Popper
  //       {...props}
  //       placement="bottom-start" // Adjust the placement as needed
  //       modifiers={[
  //         {
  //           name: "offset",
  //           options: {
  //             offset: [0, 8], // Adjust the offset to position the dropdown
  //           },
  //         },
  //       ]}
  //       ref={ref}
  //     />
  //   );
  // });

  // useEffect(() => {
  //   // Fetch models from the API when the component mounts
  //   fetchModels(searchQuery);
  // }, [searchQuery]);

  const useStyles = styled((theme) => ({
    select: {
      width: "100%", // Adjust the width as needed
      "& .MuiSelect-select.MuiSelect-select": {
        paddingBottom: theme.spacing(1), // Adds spacing below the dropdown icon
      },
    },
  }));

  const fetchModels = async (name) => {
    try {
      const params = new URLSearchParams({
        name: name, // Use the search query as the 'name' parameter
      });

      const url = `https://localhost:7066/api/Model/DropDown?${params}`;
      const response = await axios.get(url);
      console.log("API response:", response.data); // Log the API response

      if (response.data && Array.isArray(response.data)) {
        console.log("Fetched models:", response.data); // Log the fetched models
        setModels(response.data);
      } else {
        console.error(
          "API response does not contain an array of models:",
          response.data
        );
      }
    } catch (error) {
      console.error("Error:", error);
    }
  };

  const fetchTypes = async (name) => {
    try {
      const params = new URLSearchParams({
        name: name, // Use the search query as the 'name' parameter
      });

      const url = `https://localhost:7066/api/EquipmentType/DropDown?${params}`;
      const response = await axios.get(url);
      console.log("API response:", response.data); // Log the API response

      if (response.data && Array.isArray(response.data)) {
        console.log("Fetched models:", response.data); // Log the fetched models
        setTypes(response.data);
      } else {
        console.error(
          "API response does not contain an array of models:",
          response.data
        );
      }
    } catch (error) {
      console.error("Error:", error);
    }
  };

  const fetchModelsDebounced = debounce(fetchModels, 300);
  useEffect(() => {
    // Fetch models from the API when the component mounts or searchQuery changes
    fetchModels(searchQuery);
  }, [searchQuery]);

  const fetchTypesDebounced = debounce(fetchTypes, 300);
  useEffect(() => {
    // Fetch models from the API when the component mounts or searchQuery changes
    fetchTypes(searchQueryfortypes);
  }, [searchQueryfortypes]);

  // const StyledSelect = styled(Select)({
  //   width: "100%",
  //   marginTop: theme.spacing(1),
  //   "& .MuiSelect-select.MuiSelect-select": {
  //     paddingBottom: theme.spacing(1),
  //   },
  // });
  // const StyledMenuItem = styled(MenuItem)({
  //   width: "20%",
  //   // Match the width of the StyledSelect
  // });

  const submitForm = async (e) => {
    e.preventDefault();

    try {
      const response = await fetch("/api/Equipment/NewEquipment", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          ...formData,
          ModelId: selectedModel ? selectedModel.id : null, // Use selectedModel.id if it exists, otherwise set to null
        }),
      });

      if (response.ok) {
        console.log("Equipment created successfully.");
      } else {
        const errorMessage = await response.text();
        console.error("Error:", errorMessage);
      }
    } catch (error) {
      console.error("Error:", error);
    }
  };
  const classes = useStyles();

  return (
    <>
      <form className="FormMain" onSubmit={submitForm}>
        <h2 className="heading">Create Equipment</h2>
        <div className="FormContainer">
          <div className="FormLeftSide">
            {/* <h2>Identification</h2> */}
            <div>
              <FormGroup className="mb-3">
                <FormLabel>Equipment Name</FormLabel>
                <TextField type="text" name="Name" />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Unit Number</FormLabel>
                <TextField type="number" name="UnitNumber" />
              </FormGroup>

              <FormGroup className="mb-3">
                <FormLabel>Description</FormLabel>
                <TextField type="number" name="Description" />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Identification</FormLabel>
                <TextField type="number" name="Identification" />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>OperationSite</FormLabel>
                <TextField type="number" name="OperationSiteid" />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Manufacture</FormLabel>
                <TextField type="text" name="ManufactureId" />
              </FormGroup>
            </div>
            <div>
              <FormGroup className="mb-3">
                <FormLabel>ProductionYear</FormLabel>
                <TextField type="number" name="ProductionYear" />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>SerialNumber</FormLabel>
                <TextField type="text" name="SerialNumber" />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Capacity</FormLabel>
                <TextField type="text" name="Capacity" />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Type</FormLabel>
                <Autocomplete
                  id="type-autocomplete"
                  options={Types}
                  getOptionLabel={(type) => type.name}
                  value={selectedType} // Bind selectedModelId to the Autocomplete value
                  onChange={(event, newValue) => {
                    setSelectedType(newValue); // Update selectedModel when a model is selected
                  }}
                  onInputChange={(event, newInputValue) => {
                    setSearchQueryfortypes(newInputValue); // Update searchQuery as input changes
                  }}
                  inputValue={searchQueryfortypes}
                  renderInput={(params) => (
                    <TextField
                      {...params}
                      label="Search or Select Model"
                      variant="outlined"
                    />
                  )}
                  renderOption={(props, option) => (
                    <li {...props}>{option.name}</li>
                  )}
                  PopperProps={{
                    placement: "bottom-start", // Adjust the placement as needed
                    modifiers: [
                      {
                        name: "offset",
                        options: {
                          offset: [0, 8], // Adjust the offset to position the dropdown
                        },
                      },
                    ],
                  }}
                />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Model</FormLabel>
                <Autocomplete
                  id="model-autocomplete"
                  options={models}
                  getOptionLabel={(model) => model.name}
                  value={selectedModel} // Bind selectedModelId to the Autocomplete value
                  onChange={(event, newValue) => {
                    setSelectedModel(newValue); // Update selectedModel when a model is selected
                  }}
                  onInputChange={(event, newInputValue) => {
                    setSearchQuery(newInputValue); // Update searchQuery as input changes
                  }}
                  inputValue={searchQuery}
                  renderInput={(params) => (
                    <TextField
                      {...params}
                      label="Search or Select Model"
                      variant="outlined"
                    />
                  )}
                  renderOption={(props, option) => (
                    <li {...props}>{option.name}</li>
                  )}
                  PopperProps={{
                    placement: "bottom-start", // Adjust the placement as needed
                    modifiers: [
                      {
                        name: "offset",
                        options: {
                          offset: [0, 8], // Adjust the offset to position the dropdown
                        },
                      },
                    ],
                  }}
                />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Image</FormLabel>
                <TextField type="file" name="Image" accept="image/*" />
              </FormGroup>
            </div>
          </div>
          <div className="FormRightSide">
            <h2>Pm Trucking</h2>
            <FormGroup className="mb-3">
              <FormLabel>Department</FormLabel>
              <TextField type="number" name="Departmentid" />
            </FormGroup>
            <FormGroup className="mb-3">
              <FormLabel>LastMaintenaceDate</FormLabel>
              <TextField type="date" name="LastMaintenaceDate" />
            </FormGroup>
            <FormGroup className="mb-3">
              <FormLabel>CurrentValue</FormLabel>
              <TextField type="number" name="CurrentValue" />
            </FormGroup>
            <FormGroup className="mb-3">
              <FormLabel>UsageLocation</FormLabel>
              <TextField type="string" name="UsageLocation" />
            </FormGroup>
          </div>
        </div>
        <Button type="submit" variant="contained" color="primary">
          Submit
        </Button>
      </form>
    </>
  );
};

export default FormCreateEquipment;
