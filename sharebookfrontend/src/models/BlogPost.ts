class Blogpost {
    id: number;
    subject: string;
    message: string;
    profileId: number
  
    constructor(id: number, subject: string, message: string, profileId: number) {
      this.id = id;
      this.subject = subject;
      this.message = message;
      this.profileId = profileId;
    }
  }
  
  export default Blogpost;