import React from "react";
import axios from "axios";

export default class Profiles extends React.Component {
  state = {
    profiles: [],
  };

  componentDidMount() {
    axios.get(`https://localhost:7179/Profile/GetAll`).then((res) => {
      const profiles = res.data;
      this.setState({ profiles });
    });
  }

  render() {
    return (
      <ul>
        {this.state.profiles.map((profiles) => (
          <li key={profiles["id"]}>{profiles["name"]}</li>
        ))}
      </ul>
    );
  }
}
