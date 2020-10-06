db.createUser({
  user: "jonasceolin",
  pwd: "12345678",
  roles: [
    {
      role: "readWrite",
      db: "taskboard",
    },
  ],
});
